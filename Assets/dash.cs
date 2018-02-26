using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour {

	Rigidbody thisRigidbody;


	// Use this for initialization
	void Start () {
		thisRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			thisRigidbody.AddForce(-250f, 0f, 0f);
		}

		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			thisRigidbody.AddForce(250f, 0f, 0f);
		}
	}
}
