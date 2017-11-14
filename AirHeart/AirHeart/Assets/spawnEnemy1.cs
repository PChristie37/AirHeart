using UnityEngine;
using System.Collections;

public class spawnEnemy1 : MonoBehaviour 
{
	public GameObject enemy;
	public GameObject spawn;
	private float timer  = 0;



	// Use this for initialization
	void Start () 
	{

	}
		

	void OnTriggerEnter2D(Collider2D other)
	{

		timer += Time.deltaTime;
		if(timer > .05)
		{
				Instantiate(enemy, spawn.transform.position, Quaternion.identity);
				timer = 0;
		}

	}
}

