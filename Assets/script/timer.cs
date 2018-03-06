using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {



	public Text timerText;

	public float timeSinceStart = 0;

	string timeSinceStartString;

	public int lengthOfTimeString = 4;

	public bool startTimer = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (startTimer) {

			timeSinceStart += Time.deltaTime;
			timeSinceStartString = timeSinceStart.ToString ();

			if (timeSinceStart > 10) {
				lengthOfTimeString = 5;
			} else if (timeSinceStart > 100) {
				lengthOfTimeString = 6;
			} else if (timeSinceStart > 1000) {
				lengthOfTimeString = 7;
			} else if (timeSinceStart > 10000) {
				lengthOfTimeString = 8;
			} 

			timerText.text = timeSinceStartString.Substring (0, lengthOfTimeString);
		}

	}
}
