using UnityEngine;
using UnityEngine;
using System.Collections;

public class text4 : MonoBehaviour {
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
			GUI.Label(new Rect(10,10,500,500), "There is a strong force on \n this island. Whoever is \n reading this you must \n be warned that this is \n were the remains of Atlantis \n are. Atlantis devours anything \n that comes near. ", guiStyle);
	}
}
