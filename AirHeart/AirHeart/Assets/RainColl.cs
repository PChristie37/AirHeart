using UnityEngine;
using System.Collections;

public class RainColl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}




	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "SpawnEnemy")
		{
			Destroy(other.gameObject);

		}

	}
}
