Shader "UVFree/Legacy/DiffuseTopBottom" {
	Properties {
		[Toggle(_UVFREE_LOCAL)] _UVFreeLocal ("Use Local Space (instead of Global)", Float) = 0
		[Toggle(_UVFREE_VERTEX_COLOR)] _UVFreeVertexColor ("Use Vertex Color", Float) = 0
		[Toggle(_UVFREE_RIM)] _UVFreeRim ("Use Rim Lighting", Float) = 0
		[Toggle(_UVFREE_BOTTOM)] _UVFreeBottom ("Use Bottom", Float) = 1
		[Toggle(_EMISSION)] _Emission ("Use Emission", Float) = 0
		_TexPower ("Texture Power", Range(0, 20)) = 10
		_TopMultiplier ("Top Multiplier (+Y)", Range(0, 8)) = 1
		_BottomMultiplier ("Bottom Multiplier (-Y)", Range(0, 8)) = 0
		_Color ("Tint", Vector) = (1,1,1,1)
		_MainTex ("Base Color (RGB) Gloss (A)", 2D) = "white" {}
		_VertexColorStrength ("Vertex Color Strength", Range(0, 1)) = 0
		_BumpScale ("Bump Scale", Range(-2, 2)) = 1
		_BumpMap ("Normal Map", 2D) = "bump" {}
		_EmissionMultiplier ("Emission Multiplier", Float) = 0
		_EmissionColor ("Emission Color", Vector) = (0,0,0,1)
		_EmissionMap ("Emission", 2D) = "white" {}
		_RimMultiplier ("Rim Multiplier", Range(0, 8)) = 0
		_RimColor ("Rim Color (RGB) Strength (A)", Vector) = (1,1,1,1)
		_RimPower ("Rim Power", Range(0, 16)) = 5
		_TopColor ("Tint", Vector) = (1,1,1,1)
		_TopMainTex ("Base Color (RGB) Gloss (A)", 2D) = "white" {}
		_TopBumpScale ("Bump Scale", Range(-2, 2)) = 1
		_TopBumpMap ("Normal Map", 2D) = "bump" {}
		_TopEmissionMultiplier ("Emission Multiplier", Float) = 0
		_TopEmissionColor ("Emission Color", Vector) = (0,0,0,1)
		_TopEmissionMap ("Emission", 2D) = "white" {}
		_BottomColor ("Tint", Vector) = (1,1,1,1)
		_BottomMainTex ("Base Color (RGB) Gloss (A)", 2D) = "white" {}
		_BottomBumpScale ("Bump Scale", Range(-2, 2)) = 1
		_BottomBumpMap ("Normal Map", 2D) = "bump" {}
		_BottomEmissionMultiplier ("Emission Multiplier", Float) = 0
		_BottomEmissionColor ("Emission Color", Vector) = (0,0,0,1)
		_BottomEmissionMap ("Emission", 2D) = "white" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "Diffuse"
	//CustomEditor "UVFreeLegacyTopBottomGUI"
}