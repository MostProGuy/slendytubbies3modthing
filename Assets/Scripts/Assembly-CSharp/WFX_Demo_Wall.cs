using UnityEngine;

public class WFX_Demo_Wall : MonoBehaviour
{
	public WFX_Demo HECOOOBKPFJ;

	private void __BB_OBFUSCATOR_22()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1440f))
		{
			GameObject gameObject = HECOOOBKPFJ.__BB_OBFUSCATOR_83();
			gameObject.transform.position = hitInfo.point;
			gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
		}
	}

	private void __BB_OBFUSCATOR_10()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1720f))
		{
			GameObject gameObject = HECOOOBKPFJ.__BB_OBFUSCATOR_11();
			gameObject.transform.position = hitInfo.point;
			gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
		}
	}

	private void OnMouseDown()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 9999f))
		{
			GameObject gameObject = HECOOOBKPFJ.spawnParticle();
			gameObject.transform.position = hitInfo.point;
			gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1823f))
		{
			GameObject gameObject = HECOOOBKPFJ.__BB_OBFUSCATOR_92();
			gameObject.transform.position = hitInfo.point;
			gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
		}
	}

	private void __BB_OBFUSCATOR_20()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 715f))
		{
			GameObject gameObject = HECOOOBKPFJ.__BB_OBFUSCATOR_92();
			gameObject.transform.position = hitInfo.point;
			gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 617f))
		{
			GameObject gameObject = HECOOOBKPFJ.__BB_OBFUSCATOR_9();
			gameObject.transform.position = hitInfo.point;
			gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
		}
	}

	private void __BB_OBFUSCATOR_18()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 477f))
		{
			GameObject gameObject = HECOOOBKPFJ.__BB_OBFUSCATOR_9();
			gameObject.transform.position = hitInfo.point;
			gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1861f))
		{
			GameObject gameObject = HECOOOBKPFJ.__BB_OBFUSCATOR_92();
			gameObject.transform.position = hitInfo.point;
			gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
		}
	}

	private void __BB_OBFUSCATOR_11()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1549f))
		{
			GameObject gameObject = HECOOOBKPFJ.__BB_OBFUSCATOR_11();
			gameObject.transform.position = hitInfo.point;
			gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 528f))
		{
			GameObject gameObject = HECOOOBKPFJ.__BB_OBFUSCATOR_92();
			gameObject.transform.position = hitInfo.point;
			gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 526f))
		{
			GameObject gameObject = HECOOOBKPFJ.__BB_OBFUSCATOR_38();
			gameObject.transform.position = hitInfo.point;
			gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 365f))
		{
			GameObject gameObject = HECOOOBKPFJ.__BB_OBFUSCATOR_9();
			gameObject.transform.position = hitInfo.point;
			gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (GetComponent<Collider>().Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1026f))
		{
			GameObject gameObject = HECOOOBKPFJ.__BB_OBFUSCATOR_11();
			gameObject.transform.position = hitInfo.point;
			gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);
		}
	}
}
