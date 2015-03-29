using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lvl1Complete : MonoBehaviour {

	public Camera lvl1Camera;
	public Camera mainCamera;
	public GameObject llama;
	public AudioSource endNoise;
	
	// Use this for initialization
	void Start () {
		lvl1Camera.enabled = false;
		mainCamera.enabled = true;
		endNoise.mute = true;
		llama.transform.position = new Vector3 (-7.6f, -13.8f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Scores.totalWater == 3) {
			endNoise.mute = false;
			mainCamera.enabled = false;
			lvl1Camera.enabled = true;
			llama.transform.position = new Vector3 (6.7f, -8.49F, 0);

		}
	}
}
