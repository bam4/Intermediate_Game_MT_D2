using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visualizeHingeJoint : MonoBehaviour {

	LineRenderer thisLineRenderer;

	public GameObject playerCharacter;
	 
	hookZoneOperation thisHookZoneOperationScript;

	public GameObject hookZoneGO;


	// Use this for initialization
	void Start () {
		thisLineRenderer = GetComponent<LineRenderer> ();


		thisHookZoneOperationScript = hookZoneGO.GetComponent<hookZoneOperation> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (thisHookZoneOperationScript.inTheZone) {
			thisLineRenderer.enabled = true;
			thisLineRenderer.SetPosition (0, playerCharacter.transform.position);
			thisLineRenderer.SetPosition (1, this.transform.position);

		} else {
			thisLineRenderer.enabled = false;

		}


	}
}
