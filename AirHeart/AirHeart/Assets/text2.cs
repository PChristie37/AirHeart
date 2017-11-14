using UnityEngine;
using System.Collections;

public class text2 : MonoBehaviour {
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
			GUI.Label(new Rect(10,10,500,500), "Help! \n Beware of this island! \n The magetic fields here pulled \n my plane down!", guiStyle);
	}
}


