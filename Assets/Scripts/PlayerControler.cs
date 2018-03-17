using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerControler : MonoBehaviour {

	Rigidbody player;
	public float moveForce = 50;

	// Use this for initialization
	void Start () {
		player = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 moveVec = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal")*moveForce,0, CrossPlatformInputManager.GetAxis("Vertical")* moveForce);

		player.AddForce (moveVec);
	}
}
