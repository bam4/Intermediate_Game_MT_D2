using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class keyboardText : MonoBehaviour {

	public Text highscoreNameEntryText;

	public GameObject highScoreGameObject;

	highScoreAgent highScoreAgentInKeyboardText;

	// Use this for initialization
	void Start () {
		highScoreAgentInKeyboardText = highScoreGameObject.GetComponent<highScoreAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown && highscoreNameEntryText.text == "Enter at least one character.") {
			highscoreNameEntryText.text = "";
		}



		foreach (char c in Input.inputString)
		{
			if (c == '\b') // has backspace/delete been pressed?
			{
				if (highscoreNameEntryText.text.Length != 0)
				{
					highscoreNameEntryText.text = highscoreNameEntryText.text.Substring(0, highscoreNameEntryText.text.Length - 1);
				}
			}
			else if ((c == '\n') || (c == '\r')) // enter/return
			{
				//print("User entered their name: " + highscoreNameEntryText.text);


			}
			else
			{
				highscoreNameEntryText.text += c;
			}
		}


	}
}
