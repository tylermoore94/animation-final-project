﻿using UnityEngine;
using System.Collections;

public class FireCannon2 : MonoBehaviour {

	private GameObject cannonBall;
	public float speed;
	private float interval;
	public GameObject ball;
<<<<<<< HEAD
	private bool maxReached;
=======

>>>>>>> master
	// Use this for initialization
	void Start () {
		speed = 100.0f;
		interval = 1.015f;
		maxReached = false;
	}

	// Update is called once per frame
	void Update () {
		if (Player2_Control.isActive) {
			if (Input.GetKey (KeyCode.Space) && !maxReached) {
				speed *= interval;
				if (speed > 10000.0f) {
					maxReached = true;
				}
				print (speed);
			}
			if (Input.GetKeyUp (KeyCode.Space) || maxReached) {
				cannonBall = (GameObject)Instantiate (ball, transform.position, transform.rotation);
				Rigidbody ballDynamics = cannonBall.GetComponent<Rigidbody> ();
				ballDynamics.AddForce (transform.forward * speed);
				speed = 100.0f;
				maxReached = false;
			}
		}
		GlobalVariables.POWER_LEVEL = speed;
	}

	///
	/// FAILED ATTEMPT AT MANAGING MULTI-THREADING :(
	///
//	// Use this for initialization
//	void Start () {
//		speed = GlobalVariables.MIN_FIRING_SPEED;
//	}
//
//	// Update is called once per frame
//	void Update () {
//		if (FiringControl.isPlayer2InControl() && FiringControl.PermissionToFire()) {
//			if (Input.GetKey (KeyCode.Space)) {
//				selectSpeed ();
//				print (speed);
//			}
//			if (Input.GetKeyUp (KeyCode.Space)) {
//				fire ();
//			}
//		}
//	}
//
//	void selectSpeed() {
//		if (speed < GlobalVariables.MAX_FIRING_SPEED)
//			speed += GlobalVariables.FIRING_VELOCITY_CHANGE;
//		else
//			fire();
//	}
//
//	void fire () {
//		cannonBall = (GameObject)Instantiate (ball, transform.position, transform.rotation);
//		Rigidbody ballDynamics = cannonBall.GetComponent<Rigidbody> ();
//		ballDynamics.AddForce (transform.forward * speed);
//		FiringControl.RevokeFiringControl ();
//		speed = GlobalVariables.MIN_FIRING_SPEED;
//	}
}
