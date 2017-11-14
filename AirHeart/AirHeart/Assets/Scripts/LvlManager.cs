using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LvlManager : MonoBehaviour {
	
	public int score;
	
	public Rect labelPosition;
	public GUIStyle labelStyle;


	// Use this for initialization
	void Start () {
	}

	void Awake () {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "1") {
			score = 0;
		}
		else {
			score = PlayerPrefs.GetInt ("score");
		}
	}
	
	// Update is called once per frame
	void Update () {
	


	}


	public void AddPoints(int points)
	{
		score += points;

		PlayerPrefs.SetInt("score", score);
		//PlayerPrefs.Save();
	}


	void OnGUI()
	{
		GUI.Label (labelPosition, "Score: " + score.ToString(), labelStyle);

	}

}