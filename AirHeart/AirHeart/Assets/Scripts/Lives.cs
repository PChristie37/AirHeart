using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

	public int lives = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (lives == 0) {
			Application.LoadLevel ("GameOver");
		}
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		
		if (other.tag == "Player") {
			lives = lives -1;
			
		}
}
}