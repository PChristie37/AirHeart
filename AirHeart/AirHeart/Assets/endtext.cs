using UnityEngine;
using System.Collections;

public class endtext : MonoBehaviour {

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
		guiStyle.fontSize = 53;
		if(showName)
			GUI.Label(new Rect(10,10,500,500), "A Cave! Shelter! I am going to see what I can find.", guiStyle);

	}
}
