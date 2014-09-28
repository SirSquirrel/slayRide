using UnityEngine;
using System.Collections;

public class P2Control : MonoBehaviour {
	
	public float maxSpeed = 10f;
	public bool isDead = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float xMove = Input.GetAxis("Horizontal2");
		float yMove = Input.GetAxis("Vertical2");
		
		//change velocity
		rigidbody2D.velocity = new Vector2(xMove * maxSpeed, yMove * maxSpeed);
		
	}
}

