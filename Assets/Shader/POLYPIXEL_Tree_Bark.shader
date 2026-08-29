Shader "POLYPIXEL/Tree_Bark" {
	Properties {
		_BumpMap ("Normal Map", 2D) = "bump" {}
		_MainTex ("Base Color", 2D) = "white" {}
		_Metallic ("Metallic", Range(0, 1)) = 0
		_Roughness ("Roughness", Range(0, 2)) = 2
		_MetallicRoughness ("Metallic Roughness", 2D) = "white" {}
		_AOmap ("AO map", 2D) = "gray" {}
		_AO ("AO", Range(0, 3)) = 1
		[MaterialToggle] _AO_toggle ("AO_toggle", Float) = -1
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
	Fallback "Diffuse"
	//CustomEditor "ShaderForgeMaterialInspector"
}