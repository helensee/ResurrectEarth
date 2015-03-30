using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnitySampleAssets.CrossPlatformInput;

public class Scores : MonoBehaviour {

	public static int totalWater { get; set; }
	public static int totalDirt { get; set; }

	private Vector2 scale = new Vector2(1, 1);
	private Vector2 pivotPoint;
	void OnGUI() {
		pivotPoint = new Vector2(Screen.width - 50, 1);
		GUIUtility.ScaleAroundPivot(scale, pivotPoint);
		if (GUI.Button (new Rect (Screen.width / 2 - 370, Screen.height / 2 - 140, 150, 50), "Score: " + totalWater)) {
		}
		
	}
	Text waterDisplay;

	// Use this for initialization
	void Awake(){
		waterDisplay = GetComponent<Text> (); 
	}
	// Update is called once per frame
	void Update () {

	}
}
