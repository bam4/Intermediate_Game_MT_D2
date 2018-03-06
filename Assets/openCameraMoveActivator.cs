using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openCameraMoveActivator : MonoBehaviour {

	public static bool isThisFirstRun = true;


	public openingCameraMove thisOpeningCameraMove;

	// This is the RigidBody for the player.
	Rigidbody playerRigidBody;
	// This is the camera that is attachd to the player.
	public GameObject playerObject;

	public Camera introCamera;

	//public GameObject cameraManager;

	void Awake() {
		if (isThisFirstRun) {

			playerRigidBody = playerObject.GetComponent<Rigidbody> ();

			playerRigidBody.useGravity = false;

			introCamera.enabled = true;

			thisOpeningCameraMove.enabled = true;


		} else {

			playerRigidBody = playerObject.GetComponent<Rigidbody> ();

			thisOpeningCameraMove.enabled = false;

			playerRigidBody.useGravity = true;

			introCamera.enabled = false;

			thisOpeningCameraMove.enabled = false;

		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
