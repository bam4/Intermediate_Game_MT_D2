using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canHook : MonoBehaviour {

	// This is the hinge joint that the player is attached to. It is a component of this GameObject.
	HingeJoint thisHingeJoint;
	// This is the HookZone GameObject, which is our child.
	public GameObject hookZoneGO;

	hookZoneOperation thisHookZoneOperationScript;

	Rigidbody hookZoneRB;

	LineRenderer thisLineRenderer;

	//public Gradient connectedGradient;

	//public Gradient unconnectedGradient;

	public Material black;

	public Material green;


	// This is the player's rigidbody, intialized in the scene.
	public Rigidbody playerRB;

	// Use this for initialization
	void Start () {
		
		thisHookZoneOperationScript = hookZoneGO.GetComponent<hookZoneOperation> ();

		thisHingeJoint = GetComponent<HingeJoint> ();
		thisLineRenderer = GetComponent<LineRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (thisHookZoneOperationScript.inTheZone) {
			if (thisHingeJoint.connectedBody == null) {
				if (Input.GetKeyDown (KeyCode.Space)) {
					thisHingeJoint.connectedBody = playerRB;
//					thisLineRenderer.material.color = Color.black;
					thisLineRenderer.startColor =Color.green;
					thisLineRenderer.endColor =Color.green;

				}
			} else if (thisHingeJoint.connectedBody == playerRB) {
				if (Input.GetKeyUp (KeyCode.Space)) {
					thisHingeJoint.connectedBody = null;
					thisLineRenderer.material.color = Color.green;


				}
			}
		}
		

	}
}
