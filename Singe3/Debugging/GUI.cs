using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ImGuiNET;
using Singe3.Rendering;
using Singe3.Rendering.Implementations.Direct3D11;
using Singe3.Resources;

namespace Singe3.Debugging
{
    /// <summary>
    /// Subsystem for an immediate-mode GUI. Depends on the <see cref="Renderer"/> and <see cref="ResourceLoader"/> subsystems for full functionality.
    /// </summary>
    [CallAfter(typeof(ResourceLoader))]
    public sealed class GUI : Subsystem
    {
        private Renderer renderer;
        private Texture fontTexture;
        private Mesh mesh;
        private Material material;
        private int nextGuiId = 1;
        private List<int> keys = new List<int>();

        private static List<Texture> textures = new();
        private static List<IntPtr> ids = new();

        private GUI()
        {

        }

        internal IntPtr NewTextureId(Texture texture)
        {
            var id = new IntPtr(nextGuiId);

            textures.Add(texture);
            ids.Add(id);

            return id;
        }

        internal void DestroyTextureId(IntPtr imGuiId)
        {
            ids.Remove(imGuiId);
            textures.Remove(GetTexture(imGuiId));
        }

        private Texture GetTexture(IntPtr id)
        {
            return textures[ids.IndexOf(id)];
        }

        private IntPtr GetId(Texture texture)
        {
            return ids[textures.IndexOf(texture)];
        }

        public override void OnInitialize(ApplicationContext context)
        {
            ImGui.CreateContext();
            ImGuiIOPtr io = ImGui.GetIO();
            io.Fonts.AddFontDefault();

            ImGui.CreateContext();

            keys.Add(io.KeyMap[(int)ImGuiKey.Tab] = (int)Key.Tab);
            keys.Add(io.KeyMap[(int)ImGuiKey.LeftArrow] = (int)Key.LeftArrow);
            keys.Add(io.KeyMap[(int)ImGuiKey.RightArrow] = (int)Key.RightArrow);
            keys.Add(io.KeyMap[(int)ImGuiKey.UpArrow] = (int)Key.UpArrow);
            keys.Add(io.KeyMap[(int)ImGuiKey.DownArrow] = (int)Key.DownArrow);
            keys.Add(io.KeyMap[(int)ImGuiKey.PageUp] = (int)Key.PageUp);
            keys.Add(io.KeyMap[(int)ImGuiKey.PageDown] = (int)Key.PageDown);
            keys.Add(io.KeyMap[(int)ImGuiKey.Home] = (int)Key.Home);
            keys.Add(io.KeyMap[(int)ImGuiKey.End] = (int)Key.End);
            keys.Add(io.KeyMap[(int)ImGuiKey.Delete] = (int)Key.Delete);
            keys.Add(io.KeyMap[(int)ImGuiKey.Backspace] = (int)Key.Backspace);
            keys.Add(io.KeyMap[(int)ImGuiKey.Enter] = (int)Key.Enter);
            keys.Add(io.KeyMap[(int)ImGuiKey.Escape] = (int)Key.Esc);
            keys.Add(io.KeyMap[(int)ImGuiKey.Space] = (int)Key.Space);
            keys.Add(io.KeyMap[(int)ImGuiKey.A] = (int)Key.A);
            keys.Add(io.KeyMap[(int)ImGuiKey.C] = (int)Key.C);
            keys.Add(io.KeyMap[(int)ImGuiKey.V] = (int)Key.V);
            keys.Add(io.KeyMap[(int)ImGuiKey.X] = (int)Key.X);
            keys.Add(io.KeyMap[(int)ImGuiKey.Y] = (int)Key.Y);
            keys.Add(io.KeyMap[(int)ImGuiKey.Z] = (int)Key.Z);


            renderer = context.Renderer;

            if (renderer == null) 
            {
                context.Debug?.Warn("The GUI subsystem wont render without the renderer subsystem!");
                return;
            }

            unsafe
            {
                io.Fonts.GetTexDataAsRGBA32(out byte* pixels, out int width, out int height, out int bytesPerPixel);

                var pixelData = new Span<byte>(pixels, width * height * bytesPerPixel);
                
                fontTexture = renderer.CreateTexture(width, height, DataFormat.R8G8B8A8, pixelData.ToArray());
            }

            io.Fonts.SetTexID(fontTexture.GetGuiTextureID());

            mesh = renderer.CreateMesh(new ImDrawVert[1], new uint[1]);
            material = renderer.CreateMaterial();

            var resourceLoader = context.ResourceLoader;

            var vsResource = resourceLoader.GetResourceHandle(new ResourcePath("Singe3::Singe3.Assets.Shaders.GuiVert.hlsl", ResourceLocation.EmbeddedResource));
            var psResource = resourceLoader.GetResourceHandle(new ResourcePath("Singe3::Singe3.Assets.Shaders.GuiPixel.hlsl", ResourceLocation.EmbeddedResource));

            var vsSource = resourceLoader.Load<string>(vsResource);
            var psSource = resourceLoader.Load<string>(psResource);

            var vs = renderer.CreateVertexShader(vsSource);
            var ps = renderer.CreatePixelShader(psSource);

            material.VertexShader.Set(vs);
            material.PixelShader.Set(ps);

            vs.SetExplicitVertexLayout(new[]
            {
                new VertexLayoutElement("POSITION", 2, 32, VertexElementType.Float, 0),
                new VertexLayoutElement("TEXCOORD", 2, 32, VertexElementType.Float, 0),
                new VertexLayoutElement("COLOR", 4, 8, VertexElementType.Unorm, 0),
            });

            base.OnInitialize(context);
        }

        bool started = false;

        private void Context_AfterUpdate(object sender, EventArgs e)
        {
            ImGui.ShowDemoWindow();

            ImGui.EndFrame();
        }

        private void Context_BeforeUpdate(object sender, EventArgs e)
        {
            var io = ImGui.GetIO();
            io.DeltaTime = Time.DeltaTimeF;
            io.DisplaySize = (sender as ApplicationContext).Platform.GetSize().ToVector2();
            io.MousePos = Input.GetMousePosition();
            io.MouseDown[0] = Input.GetKey(Key.LeftMouse);
            io.MouseDown[1] = Input.GetKey(Key.RightMouse);
            io.MouseDown[2] = Input.GetKey(Key.MiddleMouse);
            io.MouseWheel = Input.GetScrollDelta();
            io.KeyCtrl = Input.GetKeyDown(Key.LCtrl) || Input.GetKeyDown(Key.LCtrl);
            io.KeyAlt = Input.GetKeyDown(Key.LAlt) || Input.GetKeyDown(Key.LAlt);
            io.KeyShift = Input.GetKeyDown(Key.LShift) || Input.GetKeyDown(Key.LShift);
            io.KeySuper = Input.GetKeyDown(Key.LMeta) || Input.GetKeyDown(Key.LMeta);

            for (int i = 0; i < keys.Count; i++)
            {
                io.KeysDown[keys[i]] = Input.GetKey((Key)keys[i]);
            }

            foreach (var c in Input.GetTypedChars())
            {
                io.AddInputCharacter(c);
            }

            var cursor = ImGui.GetMouseCursor();

            ImGui.NewFrame();

            started = true;
        }

        public override void OnDraw(ApplicationContext context)
        {
            if (! started)
                return;

            ImGui.Render();

            RenderDrawData(ImGui.GetDrawData());

            base.OnDraw(context);
        }

        public override void OnUpdate(ApplicationContext context)
        {
            
            base.OnUpdate(context);
        }

        public override void OnDestroy(ApplicationContext context)
        {
            base.OnDestroy(context);
        }

        private unsafe void RenderDrawData(ImDrawDataPtr drawData)
        {
            // https://github.com/ocornut/imgui/blob/master/backends/imgui_impl_dx11.cpp

            if (drawData.TotalVtxCount == 0)
                return;

            // update buffers
            var vertices = new ImDrawVert[drawData.TotalVtxCount];
            int vtxOffset = 0;

            var indices = new uint[drawData.TotalIdxCount];
            int idxOffset = 0;


            for (int i = 0; i < drawData.CmdListsCount; i++)
            {
                var cmd = drawData.CmdListsRange[i];
                for (int j = 0; j < cmd.VtxBuffer.Size; j++)
                {
                    vertices[j + vtxOffset] = *cmd.VtxBuffer[j].NativePtr;
                }
                for (int j = 0; j < cmd.IdxBuffer.Size; j++)
                {
                    indices[j + idxOffset] = cmd.IdxBuffer[j];
                }
                vtxOffset += cmd.VtxBuffer.Size;
                idxOffset += cmd.IdxBuffer.Size;
            }

            float L = drawData.DisplayPos.X;
            float R = drawData.DisplayPos.X + drawData.DisplaySize.X;
            float T = drawData.DisplayPos.Y;
            float B = drawData.DisplayPos.Y + drawData.DisplaySize.Y;

            material.VertexShader.SetConstantBuffer(0, new Matrix4x4(
                2f / (R - L), 0, 0, 0,
                0, 2f / (T - B), 0, 0,
                0, 0, .5f, 0,
                (R + L) / (L - R), (T + B) / (B - T), .5f, 1.0f
                ));

            mesh.SetVertices(vertices);
            mesh.SetIndices(indices);
            (renderer as D3D11Renderer).SetState();
            //make draw calls
            vtxOffset = 0;
            idxOffset = 0;
            drawData.ScaleClipRects(ImGui.GetIO().DisplayFramebufferScale);

            renderer.SetMaterial(material);

            renderer.SetRenderTarget(renderer.GetWindowRenderTarget());

            renderer.SetViewport(0, 0, drawData.DisplaySize.X, drawData.DisplaySize.Y);

            for (int n = 0; n < drawData.CmdListsCount; n++)
            {
                ImDrawListPtr cmdList = drawData.CmdListsRange[n];

                for (int i = 0; i < cmdList.CmdBuffer.Size; i++)
                {
                    ImDrawCmdPtr pcmd = cmdList.CmdBuffer[i];

                    if (pcmd.UserCallback != IntPtr.Zero)
                    {
                        var usercallback = (delegate*<void>)pcmd.UserCallback.ToPointer();
                        usercallback();
                    }
                    else
                    {
                        material.PixelShader.SetTexture(0, GetTexture(pcmd.TextureId));

                        renderer.SetClippingRectangles(new[] { new Rectangle((int)(pcmd.ClipRect.X - drawData.DisplayPos.X), (int)(pcmd.ClipRect.Y - drawData.DisplayPos.Y), (int)(pcmd.ClipRect.Z - drawData.DisplayPos.X), (int)(pcmd.ClipRect.W - drawData.DisplayPos.Y)) });

                        mesh.DrawPart((int)pcmd.ElemCount, idxOffset, vtxOffset);
                    }
                    idxOffset += (int)pcmd.ElemCount;
                }
                vtxOffset += cmdList.VtxBuffer.Size;
            }

            // reset renderer state
            renderer.ClearState();
        }
        protected override void Dispose(bool disposing)
        {
            mesh.Dispose();
            material.Dispose();

            ImGui.DestroyContext();

            base.Dispose(disposing);
        }

        public static GUI Create()
        {
            return new GUI();
        }
    }
}
