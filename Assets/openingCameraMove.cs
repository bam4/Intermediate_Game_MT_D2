using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openingCameraMove : MonoBehaviour {

	// This is where the camera starts.
	public Transform firstPosition;
	// This is the second place the camera goes.
	public Transform secondPosition;
	// This is the third place the camera goes.
	public Transform thirdPosition;
	// This is the fourth place the camera goes.
	public Transform fourthPosition;
	// This is the last place the camera goes;
	public Transform startCameraPosition;

	// This is the player GO.
	//public GameObject player; 
	// This is the RigidBody for the player.
	Rigidbody playerRigidBody;
	// This is the camera that is attachd to the player.
	public GameObject playerObject;

	public GameObject cameraManager;

	// StartCounting after the camera has arrived at the player.
	bool startCounting = false;
	float count = 0;

	// This is the camera we start with.
	public Camera introCamera;

	public Camera gameCamera;
	// This is how fast the camera speeds.
	public float speed;
	// What position is the camera in?
	public int cameraPositionNumber = 0;

	public timer thisTimer;

	public dash thisDash;



	// Use this for initialization
	void Start () {

		playerRigidBody = playerObject.GetComponent<Rigidbody> ();

		//if (openCameraMoveActivator.isThisFirstRun) {

		playerRigidBody.useGravity = false;

		introCamera.enabled = true;

		cameraManager.SetActive(true);

		thisTimer.startTimer = false;

		thisDash.enabled = false;

		//}


		//playerObject.gameObject.SetActive (false);


		// Set the camera's position from the get-go.
		introCamera.transform.position = firstPosition.position;

		startCameraPosition = gameCamera.transform;
	}
	
	// Update is called once per frame
	void Update () {
		// Move this speed.
		float step = speed * Time.deltaTime;



		if (introCamera.transform.position == secondPosition.position) {
			cameraPositionNumber = 1;
		} else if (introCamera.transform.position == thirdPosition.position) {
			cameraPositionNumber = 2;
		} else if (introCamera.transform.position == fourthPosition.position) {
			startCounting = true;
		} else if (introCamera.transform.position == startCameraPosition.position) {
			cameraPositionNumber = 4;
		} 

		if (startCounting) {
			count += Time.deltaTime;
		}

		if (count >= 1.5 && count <= 2) {
			cameraPositionNumber = 3;
		}

		Debug.Log (cameraPositionNumber);

		switch (cameraPositionNumber) {
				
		case 0:
			introCamera.transform.position = Vector3.MoveTowards (introCamera.transform.position, secondPosition.position, step);
			break;
		case 1:
			introCamera.transform.position = Vector3.MoveTowards (introCamera.transform.position, thirdPosition.position, step);
			break;
		case 2:
			introCamera.transform.position = Vector3.MoveTowards (introCamera.transform.position, fourthPosition.position, step);
			break;
		case 3:
			introCamera.transform.position = Vector3.MoveTowards (introCamera.transform.position, startCameraPosition.position, step);
			

			break;
		case 4:
			Debug.Log ("Case four achieved.");
			introCamera.enabled = false;
			playerRigidBody.useGravity = true;
			openCameraMoveActivator.isThisFirstRun = false;
			thisTimer.startTimer = true;
			thisDash.enabled = true;
			//playerObject.gameObject.SetActive (true)
			break;
		}
		
		
	}
}
