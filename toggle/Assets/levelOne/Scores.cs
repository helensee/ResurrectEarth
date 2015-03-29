using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using llamaStatus;

public class Scores : MonoBehaviour {
	
	public int currentWater;
	Text waterDisplay;
	// Use this for initialization
	void Awake(){
		waterDisplay = GetComponent<Text> ();
		currentWater = 0;
	}
	// Update is called once per frame
	void Update () {
		waterDisplay.text = "Score: " + currentWater;
	}
}
