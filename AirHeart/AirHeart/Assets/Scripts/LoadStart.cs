using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void LoadGameLevel()
	{
		SceneManager.LoadScene("StartScreen");
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
