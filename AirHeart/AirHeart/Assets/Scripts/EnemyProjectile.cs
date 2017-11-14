  using UnityEngine;
using System.Collections;

public class EnemyProjectile : MonoBehaviour 
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
		if(timer > .1)
		{
			if(Input.GetKey(KeyCode.J))
			{
				Instantiate(rain, spawn.transform.position, Quaternion.identity);
			}
			timer = 0;
		}
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "Enemy") {
			Destroy (this.gameObject);
			Destroy (other.gameObject);
		}

	}
}
