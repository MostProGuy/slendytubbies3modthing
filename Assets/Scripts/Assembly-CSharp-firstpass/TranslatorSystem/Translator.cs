using UnityEngine;

namespace TranslatorSystem
{
	public class Translator
	{
		public string Translate(int ID, string fileName)
		{
			if (PlayerPrefs.GetInt("Language") > 0)
			{
				TextAsset textAsset = Resources.Load<TextAsset>(PlayerPrefs.GetInt("Language") + "/" + fileName);
				if (textAsset != null)
				{
					string[] array = textAsset.text.Split("\n"[0]);
					if (ID > 0 && ID <= array.Length)
					{
						string[] array2 = array[ID - 1].Split(":"[0]);
						if (array2.Length > 3)
						{
							string text = array2[0] + ";" + array2[1] + ":" + array2[2] + ";" + array2[3];
							array2 = text.Split(":"[0]);
						}
						else if (array2.Length > 2)
						{
							string text2 = array2[0] + ":" + array2[1] + ";" + array2[2];
							array2 = text2.Split(":"[0]);
						}
						if (array2.Length > 1)
						{
							return array2[1].Replace("#", string.Empty);
						}
					}
				}
			}
			return string.Empty;
		}
	}
}
