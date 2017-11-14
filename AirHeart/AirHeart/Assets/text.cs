using UnityEngine;
using UnityEngine;
using System.Collections;

public class text : MonoBehaviour {
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
		guiStyle.fontSize = 40;
		if(showName)
			GUI.Label(new Rect(10,10,500,500), "Warning! \n Skeletons and spirits of past \n pilots are in these woods \n haunting the land", guiStyle);
				
	}
}




