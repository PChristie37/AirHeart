﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevel5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "Player") {
			SceneManager.LoadScene("level5");
		}

	}
}
