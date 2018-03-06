using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnInstructions : MonoBehaviour {

	public GameObject instructionsButton;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void turnOnInstructionsFunction () {
		instructionsButton.SetActive (!instructionsButton.activeInHierarchy);
	}
}
