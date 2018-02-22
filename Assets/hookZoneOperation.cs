using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hookZoneOperation : MonoBehaviour {

	// This determines whether the player is in the zone or not.
	public bool inTheZone = false;

	// This is the MeshRenderer for this object.
	MeshRenderer thisMeshRenderer;

	// This is the "Empty" material for when the player is not in the hookzone.
	public Material emptyMaterial;
	// This is the HookZone material for when the player enters the material.
	public Material hookZoneMaterial;


	// Use this for initialization
	void Start () {
		// We get the MeshRenderer of this object.
		thisMeshRenderer = GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	// If the player enters the hookzone,
	void OnTriggerStay (Collider other) {
		if (other.gameObject.tag == "Player") {
			// Set the hookZone bool to true.
			inTheZone = true;
			// Set the hookZoneMaterial to hookZoneMaterial.
			thisMeshRenderer.material = hookZoneMaterial;
			Debug.Log ("We are in the zone.");
		}
	}

	// if 
	void OnTriggerExit (Collider other) {
		if (other.gameObject.tag == "Player") {
			// Set the hookZone bool to false so that the hook knows not to let the player attach to it.
			inTheZone = false;
			// Set the hookZone to the empty material.
			thisMeshRenderer.material = emptyMaterial;
		}
	}


}
