﻿using UnityEngine;
using System.Collections;

public class BulletEnemy : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
			
			transform.Translate (Vector3.left * -3 * Time.deltaTime);
		


	if((this.transform.position).x > 100)		
		{
			Destroy(this.gameObject);
		}

	}
	

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Enemy")
		{
			Destroy(other.gameObject);
			Destroy(this.gameObject);

		}


	}

}
