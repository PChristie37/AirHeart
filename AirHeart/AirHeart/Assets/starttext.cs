using UnityEngine;
using System.Collections;

public class starttext : MonoBehaviour {

	private bool showName = false;
	private GUIStyle guiStyle = new GUIStyle(); //create a new variable
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
		guiStyle.fontSize = 53; //change the font size
		//GUI.contentColor = Color.black;
		if(showName)
			GUI.Label(new Rect(10,15,800,800), "Oh my! My plane crashed! That smoke over there is from my wreck. Why \ndid I crash? I have gathered nuts and bolts from the remains so lets go \ninland and see what we can find!", guiStyle);

	}
}
