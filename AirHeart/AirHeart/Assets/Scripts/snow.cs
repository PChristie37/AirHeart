using UnityEngine;
using System.Collections;

public class snow : MonoBehaviour {
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.down * 1 * Time.deltaTime);
		if((this.transform.position).x < -5)		
		{
			Destroy(this.gameObject);
		}
		
	}
	
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			Destroy(other.gameObject);
			Destroy(this.gameObject);
		}
		
		
	}
	
}