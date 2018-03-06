using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour {

	// This is the hinge joint that the player is attached to.
	HingeJoint parentHingeJoint;

	Rigidbody myRigidBody;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {



		// 
		//parentHingeJoint = GetComponent<HingeJoint>();



		// Is this exception-handling?
		if (parentHingeJoint.connectedBody == null) {
			// Empty?
		} else if (Input.GetKeyDown(KeyCode.Space)) {
			parentHingeJoint.connectedBody = null;
		}


	}
}
