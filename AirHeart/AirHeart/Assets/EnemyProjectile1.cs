  using UnityEngine;
using System.Collections;

public class EnemyProjectile1 : MonoBehaviour 
{
	public GameObject rain;
	public GameObject spawn;
	private float timer  = 0;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;
		if(timer > 2)
		{
			float shootChance = Random.Range(0.0f, 1.0f);
			if(shootChance > 0.5f)
			{
				Instantiate(rain, spawn.transform.position, Quaternion.identity);
			}
			timer = 0;
		}
	
	}
}
