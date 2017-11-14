using UnityEngine;
using System.Collections;


public class EnemyMovement : MonoBehaviour 
{
	private float speed = .7f;
	private int direction = 1;
	private int moveState = 0;
	private float timer = 0.0f;
	
	private bool justSwitched = false;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(moveState == 0)
		{
			MoveLeftAndRight();
		}

	}
	
	private void MoveLeftAndRight()
	{
		transform.Translate(Vector3.left * speed * direction * Time.deltaTime);
		justSwitched = false;
	}

	public void HitAWall()
	{
		if(moveState == 0 && !justSwitched)
		{
			moveState = 1;
		}
	}
	
	private void SwitchDiretion()
	{
		direction *= -1;
		timer = 0;
		justSwitched = true;
		moveState = 0;
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