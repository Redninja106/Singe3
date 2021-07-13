struct PS_IN
{
	float2 tex : TEXTURE0;
};

struct PS_OUT
{
	float4 color : SV_Color;
};

PS_OUT main(PS_IN input)
{
	PS_OUT output;

	output.color = float4(1, 0, 0, 1);

	return output;
}