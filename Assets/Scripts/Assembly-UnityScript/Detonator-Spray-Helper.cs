using System;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class Detonator_0020Spray_0020Helper : MonoBehaviour
{
	public float startTimeMin;

	public float startTimeMax;

	public float stopTimeMin;

	public float stopTimeMax;

	public Material firstMaterial;

	public Material secondMaterial;

	private float startTime;

	private float stopTime;

	private float spawnTime;

	private bool isReallyOn;

	public Detonator_0020Spray_0020Helper()
	{
		stopTimeMin = 10f;
		stopTimeMax = 10f;
	}

	public virtual void Start()
	{
		isReallyOn = RuntimeServices.UnboxBoolean(UnityRuntimeServices.GetProperty(UnityRuntimeServices.GetProperty(this, "ParticleEmitter"), "emit"));
		bool flag = false;
		object property = UnityRuntimeServices.GetProperty(this, "ParticleEmitter");
		RuntimeServices.SetProperty(property, "emit", flag);
		UnityRuntimeServices.PropagateValueTypeChanges(new UnityRuntimeServices.ValueTypeChange[1]
		{
			new UnityRuntimeServices.MemberValueTypeChange(this, "ParticleEmitter", property)
		});
		spawnTime = Time.time;
		startTime = UnityEngine.Random.value * (startTimeMax - startTimeMin) + startTimeMin + Time.time;
		stopTime = UnityEngine.Random.value * (stopTimeMax - stopTimeMin) + stopTimeMin + Time.time;
		if (!(UnityEngine.Random.value <= 0.5f))
		{
			Material value = firstMaterial;
			object property2 = UnityRuntimeServices.GetProperty(this, "Renderer");
			RuntimeServices.SetProperty(property2, "material", value);
			UnityRuntimeServices.PropagateValueTypeChanges(new UnityRuntimeServices.ValueTypeChange[1]
			{
				new UnityRuntimeServices.MemberValueTypeChange(this, "Renderer", property2)
			});
		}
		else
		{
			Material value2 = secondMaterial;
			object property3 = UnityRuntimeServices.GetProperty(this, "Renderer");
			RuntimeServices.SetProperty(property3, "material", value2);
			UnityRuntimeServices.PropagateValueTypeChanges(new UnityRuntimeServices.ValueTypeChange[1]
			{
				new UnityRuntimeServices.MemberValueTypeChange(this, "Renderer", property3)
			});
		}
	}

	public virtual void FixedUpdate()
	{
		if (!(Time.time <= startTime))
		{
			bool flag = isReallyOn;
			object property = UnityRuntimeServices.GetProperty(this, "ParticleEmitter");
			RuntimeServices.SetProperty(property, "emit", flag);
			UnityRuntimeServices.PropagateValueTypeChanges(new UnityRuntimeServices.ValueTypeChange[1]
			{
				new UnityRuntimeServices.MemberValueTypeChange(this, "ParticleEmitter", property)
			});
		}
		if (!(Time.time <= stopTime))
		{
			bool flag2 = false;
			object property2 = UnityRuntimeServices.GetProperty(this, "ParticleEmitter");
			RuntimeServices.SetProperty(property2, "emit", flag2);
			UnityRuntimeServices.PropagateValueTypeChanges(new UnityRuntimeServices.ValueTypeChange[1]
			{
				new UnityRuntimeServices.MemberValueTypeChange(this, "ParticleEmitter", property2)
			});
		}
	}

	public virtual void Main()
	{
	}
}
