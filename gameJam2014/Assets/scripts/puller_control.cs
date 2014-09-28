﻿using UnityEngine;
using System.Collections;

public class puller_control : MonoBehaviour {

	public float maxSpeed = 10f;
	public static bool isDead = false;

	// Use this for initialization
	void Start () {
		isDead = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float xMove = Input.GetAxis("Horizontal");
		float yMove = Input.GetAxis("Vertical");

		//change velocity
		rigidbody2D.velocity = new Vector2(xMove * maxSpeed, yMove * maxSpeed);

	}
}
