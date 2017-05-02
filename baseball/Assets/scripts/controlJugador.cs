﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlJugador : MonoBehaviour {

	public float speed;

	private Rigidbody rb;


	void Start () {
		rb = GetComponent<Rigidbody> ();		
	}
	

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		transform.Rotate (new Vector3 (moveVertical, 0.0f, moveHorizontal) * Time.deltaTime * 100);

		//rb.AddForce (movement * speed);

	}
}
