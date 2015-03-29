using UnityEngine;

/// <summary>
/// Title screen script
/// </summary>
public class MainMenu : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 180;
		const int buttonHeight = 60;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width - 450,
			Screen.height - 150,
			buttonWidth,
			buttonHeight
			);
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect,"Play Resurrect Earth"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("mouse");
		}
	}
}