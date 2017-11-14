using UnityEngine;
using System.Collections;

public class ThrowSimulation : MonoBehaviour
{
	public GameObject[] spawnObject;
	public float radius = 1.0f;
	public float minSpawnTime = 1.0f;
	public float maxSpawnTime = 10.0f;
	public bool constantSpawn = false;

	public Transform poll;
	float speed = .5f;

	
	void Update()
	{
	
			transform.position = Vector3.MoveTowards (transform.position, poll.position, speed * Time.deltaTime);


	}


	void OnTriggerEnter2D(Collider2D other)
	{
		
		if (other.tag == "Player") {
			Application.LoadLevel("GameOver");
			}
			
		}

	void SpawnEnemy () 
	{
		float spawnRadius = radius;
		int spawnObjectIndex = Random.Range(0,spawnObject.Length);
		
		transform.position = Random.insideUnitSphere * spawnRadius;
		
		Instantiate(spawnObject[spawnObjectIndex]);
		
		if (constantSpawn == true)
		{
			Invoke ("SpawnEnemy", Random.Range (minSpawnTime,maxSpawnTime));
		}
	}
		
}
