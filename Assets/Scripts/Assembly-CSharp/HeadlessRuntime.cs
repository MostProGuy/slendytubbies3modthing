using UnityEngine;

public class HeadlessRuntime : ScriptableObject
{
	public string profileName = string.Empty;

	public int valueFramerate = 60;

	public bool valueLimitFramerate = true;

	public bool valueCamera = true;

	public bool valueConsole = true;
}
