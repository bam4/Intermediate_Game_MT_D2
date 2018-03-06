using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class getHighScore : MonoBehaviour {

	public Text timerText;

	float highScore = 20000;

	string timerTextString;

	public static float mostRecentHighScore = 20000;

	public static bool setNewHighScore = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (highScore);

//		float.TryParse(timerText.ToString(), out highScore);
//
//		Debug.Log ("highscore is:" + highScore);

//		timerTextString = timerText.text.ToString ();
//
//		Debug.Log (timerTextString);

	}



	void OnCollisionEnter (Collision collision) {
		float.TryParse(timerText.text, out highScore);

		mostRecentHighScore = highScore;
	
		//highScore = float.Parse (timerText.text.ToString());

		Debug.Log ("highscore is:" + highScore);

		SceneManager.LoadScene (2);


	}



}



