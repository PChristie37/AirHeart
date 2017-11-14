
using UnityEngine;
using System.Collections;

public class penguinControl : MonoBehaviour {
	public float maxSpeed = 1f;
	bool facingRight = true;
	public float speed = 5f;
	public bool canJump = true;
	
	Animator anim;
	
	void Start(){
		
		anim = this.GetComponent<Animator>();
	}
	
	void FixedUpdate(){
		float move = Input.GetAxis ("Horizontal");

		
		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);


		anim.SetFloat ("Speed", Mathf.Abs (move));

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
		
	}

	void Update(){
	 	
		if (Input.GetKey (KeyCode.Space) && canJump) {
			transform.Translate (Vector2.up * speed * Time.deltaTime * 5);
			//canJump = !canJump;
		
		} 
	



	
	}
	
	void Flip(){
		
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	
	
}