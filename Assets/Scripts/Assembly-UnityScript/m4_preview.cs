using System;
using UnityEngine;

[Serializable]
public class m4_preview : MonoBehaviour
{
	public GameObject target;

	private bool drawed;

	private bool aiming;

	private bool playerview;

	public m4_preview()
	{
		drawed = true;
		playerview = true;
	}

	public virtual void Start()
	{
	}

	public virtual void OnGUI()
	{
		if (GUI.Button(new Rect(10f, 10f, 50f, 25f), "fire"))
		{
			fire();
		}
		if (GUI.Button(new Rect(70f, 10f, 70f, 25f), "burst fire"))
		{
			burstfire();
		}
		if (GUI.Button(new Rect(150f, 10f, 115f, 25f), "Aim in/out"))
		{
			aim();
		}
		if (GUI.Button(new Rect(275f, 10f, 70f, 25f), "reload"))
		{
			reload();
		}
		if (GUI.Button(new Rect(355f, 10f, 85f, 25f), "holster/draw"))
		{
			draw();
		}
		if (GUI.Button(new Rect(595f, 10f, 130f, 25f), "player/world model"))
		{
			switchview();
		}
	}

	public virtual void fire()
	{
		target.GetComponent<Animation>().Play("shotSingle");
		target.GetComponent<Animation>().CrossFade("idle", 0.4f);
	}

	public virtual void burstfire()
	{
		target.GetComponent<Animation>().Play("shotBurst");
	}

	public virtual void aim()
	{
		if (!aiming)
		{
			GetComponent<Animation>()["aimIN"].speed = 2f;
			target.GetComponent<Animation>().Play("aimIN");
			aiming = true;
		}
		else
		{
			GetComponent<Animation>()["aimOUT"].speed = 2f;
			target.GetComponent<Animation>().Play("aimOUT");
			aiming = false;
			target.GetComponent<Animation>().CrossFade("idle", 1f);
		}
	}

	public virtual void reload()
	{
		GetComponent<Animation>()["reload"].speed = 1.5f;
		target.GetComponent<Animation>().Play("reload");
		target.GetComponent<Animation>().CrossFade("idle", 7f);
	}

	public virtual void draw()
	{
		if (drawed)
		{
			GetComponent<Animation>()["holster"].speed = 1.5f;
			target.GetComponent<Animation>().Play("holster");
			drawed = false;
		}
		else
		{
			GetComponent<Animation>()["draw"].speed = 1.5f;
			target.GetComponent<Animation>().Play("draw");
			drawed = true;
			target.GetComponent<Animation>().CrossFade("idle", 1.5f);
		}
	}

	public virtual void switchview()
	{
		if (playerview)
		{
			GameObject.Find("hands").GetComponent<Renderer>().enabled = false;
			GameObject.Find("rifle08_m4").GetComponent<Renderer>().enabled = false;
			GameObject.Find("rifle08_charger").GetComponent<Renderer>().enabled = false;
			GameObject.Find("m4WHD").GetComponent<Renderer>().enabled = true;
			playerview = false;
		}
		else
		{
			GameObject.Find("m4WHD").GetComponent<Renderer>().enabled = false;
			GameObject.Find("hands").GetComponent<Renderer>().enabled = true;
			GameObject.Find("rifle08_m4").GetComponent<Renderer>().enabled = true;
			GameObject.Find("rifle08_charger").GetComponent<Renderer>().enabled = true;
			playerview = true;
		}
	}

	public virtual void Main()
	{
	}
}
