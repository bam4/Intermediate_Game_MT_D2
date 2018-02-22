using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTracker : MonoBehaviour {





	public Transform target;

	public float distance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		transform.position.z = target.position.z - distance;
//		transform.position.y = target.position.y;
//		transform.position.x = target.position.x;

		transform.position = new Vector3 (target.position.x, target.position.y, (target.position.z - distance));

	}
}
