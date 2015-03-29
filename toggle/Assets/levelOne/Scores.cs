using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scores : MonoBehaviour {

	public static int totalWater { get; set; }
	public static int totalDirt { get; set; }

	Text waterDisplay;

	// Use this for initialization
	void Awake(){
		waterDisplay = GetComponent<Text> (); 
	}
	// Update is called once per frame
	void Update () {
		waterDisplay.text = "Score: " + totalWater;
	}
}
