using UnityEngine;
using System.Collections;

public class backforth : MonoBehaviour  {

	private bool dirRight = true;
	public float speed = .5f;

	void Update () {
		if (dirRight)
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		else
			transform.Translate (-Vector2.right * speed * Time.deltaTime);

		if(transform.position.x >= 60.8f) {
			dirRight = false;
		}

		if(transform.position.x <= 56.7f) {
			dirRight = true;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "Player") {
			Destroy (other.gameObject);
			Destroy (this.gameObject);
			Application.LoadLevel(Application.loadedLevel);
		}

	}
}