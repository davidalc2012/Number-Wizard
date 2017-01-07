using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max = 1001, min=1, guess;

	// Use this for initialization
	void Start () {
		print ("Welcome to number Wizard");
		print ("Pick a number a number in your head.");

		guess = max / 2;

		print ("The maximum number you can pick is: " + max);
		print ("The minimum number you can pick is: " + min);

		
		print ("Is your number higher or lower than 500?");
		print ("Up = higher, down = lower, return = equal");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//print ("UP");
			min=guess;
			guess=(min+max)/2;
			print ("Higher or lower than "+guess);
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print ("DOWN");
			max=guess;
			guess=(min+max)/2;
			print ("Higher or lower than "+guess);
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Your number is "+guess);
		}
	}
}
