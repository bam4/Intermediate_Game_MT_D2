using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class stayingLevel : MonoBehaviour {

	public GameObject parentController;

	Transform ourTransform;

	float characterRotationX; 
	float characterRotationZ; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		characterRotationX = parentController.transform.rotation.x;
		characterRotationZ = parentController.transform.rotation.z;

		//Mathf.Abs(

		//ourTransform = GetComponent<Transform> ();

		//ourTransform.rotation = new Vector3 (


	}
}
