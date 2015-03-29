using UnityEngine;
using System.Collections;
using UnitySampleAssets.CrossPlatformInput;

public class llamaBlue : MonoBehaviour {
	public Animator blueAnim;

	// Use this for initialization
	void Start () {
		blueAnim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float move = CrossPlatformInputManager.GetAxis("Horizontal");
		if (move == 0) {
			blueAnim.enabled = false;
		}
		blueAnim.enabled = true;
	}
}
