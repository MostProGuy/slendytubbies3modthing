Shader "AQUAS/Desktop and Web/One-Sided/Single-Textured" {
	Properties {
		[NoScaleOffset] _NormalTexture ("Normal Texture", 2D) = "white" {}
		_NormalTiling ("Normal Tiling", Float) = 1
		_MainColor ("Main Color", Vector) = (0,0.4627451,1,1)
		_DeepWaterColor ("Deep Water Color", Vector) = (0,0.3411765,0.6235294,1)
		_Fade ("Fade", Float) = 1.45
		_Density ("Density", Range(0, 10)) = 1.74
		_DepthTransparency ("Depth Transparency", Float) = 1.5
		_ShoreFade ("Shore Fade", Float) = 0.3
		_ShoreTransparency ("Shore Transparency", Float) = 0.04
		[MaterialToggle] _EnableReflections ("Enable Reflections", Float) = 0.6
		[HideInInspector] _ReflectionTex ("Reflection Tex", 2D) = "white" {}
		_ReflectionIntensity ("Reflection Intensity", Range(0, 1)) = 0.6
		_Distortion ("Distortion", Range(0, 2)) = 0.3
		_Specular ("Specular", Float) = 1
		_SpecularColor ("Specular Color", Vector) = (0.6985294,0.7088019,0.7088019,1)
		_Gloss ("Gloss", Float) = 0.7
		_LightWrapping ("Light Wrapping", Float) = 2
		_Refraction ("Refraction", Range(0, 1)) = 0.67
		_WaveSpeed ("Wave Speed", Float) = 40
		[NoScaleOffset] _FoamTexture ("Foam Texture", 2D) = "white" {}
		_FoamTiling ("Foam Tiling", Float) = 3
		_FoamBlend ("Foam Blend", Float) = 0.15
		_FoamVisibility ("Foam Visibility", Range(0, 1)) = 0.3
		_FoamIntensity ("Foam Intensity", Float) = 10
		_FoamContrast ("Foam Contrast", Range(0, 0.5)) = 0.25
		_FoamColor ("Foam Color", Vector) = (0.3382353,0.3456964,0.3456964,1)
		_FoamSpeed ("Foam Speed", Float) = 120
		[MaterialToggle] _EnableCustomFog ("Enable Custom Fog", Float) = 1.278023
		_FogColor ("Fog Color", Vector) = (1,1,1,1)
		_FogDistance ("Fog Distance", Float) = 1000
		_FogFade ("Fog Fade", Float) = 1
		[HideInInspector] _Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	Fallback "Diffuse"
}