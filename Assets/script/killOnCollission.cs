﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killOnCollission : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other) {

		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		//Destroy(other.gameObject);
	}
}
