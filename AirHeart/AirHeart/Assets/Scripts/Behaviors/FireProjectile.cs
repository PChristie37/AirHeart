using UnityEngine;
using System.Collections;

public class FireProjectile : AbstractBehavior {

	public float shootDelay = .5f;
	public GameObject projectilePrefab;

	public GameObject rain;
	public GameObject spawn;

	private float timeElapsed = 0f;

	// Update is called once per frame
	void Update () {
	
		if (projectilePrefab != null) {

			var canFire = Input.GetKey(KeyCode.J);

			if(canFire && timeElapsed > shootDelay){
				Instantiate(rain, spawn.transform.position, Quaternion.identity);
				timeElapsed = 0;
			}

			timeElapsed += Time.deltaTime;
		}

	}

	public void CreateProjectile(Vector2 pos){
		transform.Translate(Vector3.left * 2 * 1 * Time.deltaTime);
	}
}
