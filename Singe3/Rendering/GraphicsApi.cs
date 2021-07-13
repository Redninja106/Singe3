namespace Singe3.Rendering
{
    /// <summary>
    /// All supported graphics apis, sort by highest preference first.
    /// </summary>
    public enum GraphicsApi
    {
        Vulkan,
        Direct3D12,
        Direct3D11, 
        OpenGL,
        Direct3D10,
    }
}