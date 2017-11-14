  using UnityEngine;
using System.Collections;

public class EnemyProjectile22 : MonoBehaviour 
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

		if(Input.GetKey(KeyCode.J))
		{
	
		
			Instantiate(rain, spawn.transform.position, Quaternion.identity);
			

		}
	
	}

	public void CreateProjectile(Vector2 pos){
		transform.Translate(Vector3.left * 2 * 1 * Time.deltaTime);
	}
}
