using UnityEngine;
using UnityEngine;
using System.Collections;

public class text3 : MonoBehaviour {
	public GUIStyle guiStyle = new GUIStyle(); //create a new variable
	private bool showName = false;
	public GUISkin mySkin;

	void OnTriggerEnter2D()
	{
		showName = true;
	}
	void OnTriggerExit2D()
	{
		showName =false;
	}

	void OnGUI()
	{
		GUI.skin = mySkin;
		guiStyle.fontStyle = FontStyle.Bold;
		guiStyle.normal.textColor = Color.white;
		guiStyle.fontSize = 45;
		if(showName)
			GUI.Label(new Rect(10,10,500,500), "Get comfortable... \n There is no way off the island. \n All that live here are from \n the ancient mystical world.", guiStyle);
	}
}