using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max, min, guess;
	// Use this for initialization
	void Start () {
		startGame ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//print ("UP");
			min=guess;
			nextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print ("DOWN");
			max=guess;
			nextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Your number is "+guess);
			startGame();
		}
	}

	void startGame(){
		min = 1;
		max = 1000;
		print ("------------------------------------");
		print ("Welcome to number Wizard");
		print ("Pick a number a number in your head.");
		
		print ("The maximum number you can pick is: " + max);
		print ("The minimum number you can pick is: " + min);

		max = max + 1;
		guess = (max / 2) + Random.Range (-200, 200);

		print ("Is your number higher or lower than "+guess+"?");
		print ("Up = higher, down = lower, return = equal");
	}

	void nextGuess(){
		guess=(min+max)/2;
		print ("Is your number higher or lower than "+guess+"?");
		print ("Up = higher, down = lower, return = equal");
	}

}
