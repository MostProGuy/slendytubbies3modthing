Shader "RIOT/Grass/GrassShader (Low)" {
	Properties {
		[Header(Textures)] _MainTex ("Fur Texture (RGB)", 2D) = "white" {}
		[NoScaleOffset] _DirtTex ("Dirt Texture (RGB)", 2D) = "white" {}
		[NoScaleOffset] _HeightMap ("Height Map (Gray) ", 2D) = "white" {}
		[Header(Grass Color Properties)] _GrassColor ("Grass Color", Vector) = (0.27,0.949,0.121,1)
		_GrassBrightness ("Grass Brightness", Range(0, 1)) = 0.15
		_HeightMapBrightness ("Height Map Brightness", Range(0, 1)) = 1
		_GrassTransparency ("Grass Transparency", Range(0, 1)) = 1
		[Header(Dirt Color Properties)] [Toggle] _EnableDirt ("Enable Dirt Layer", Float) = 0
		_DirtColor ("Dirt Color", Vector) = (1,1,1,1)
		_DirtBrightness ("Dirt Brightness", Range(0, 1)) = 0.25
		_DirtTransparency ("Dirt Transparency", Range(0, 1)) = 1
		[Header(Grass Properties)] _GrassLength ("Grass Length", Range(0, 1)) = 0.075
		_GrassStiff ("Grass Stiffness", Range(0, 1)) = 0.1
		_Gravity ("Gravity Direction", Vector) = (0,0.25,0,0)
		[Header(Depth Shadow Properties)] [Toggle] _Shadows ("Depth Shadows", Float) = 0
		_ShadowStrength ("Depth Shadow Strength", Range(0, 1)) = 0.5
		[Header(Randomized Wind Properties)] _WindSpeed ("Wind Speed", Range(0, 1)) = 0.245
		_WindStrength ("Wind Strength", Range(0, 1)) = 0.15
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}