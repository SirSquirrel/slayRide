using UnityEngine;
using System.Collections;

public class multiplayer_Button : MonoBehaviour {
	
	void OnGUI()
	{
		const int buttonWidth = 150;
		const int buttonHeight = 60;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			Screen.height/2,
			buttonWidth,
			buttonHeight
			);
		
		// Draw a button for multiplayer
		if(GUI.Button(buttonRect,"Multiplayer!"))
		{
			Application.LoadLevel("multSurvival");
		}
	}
}
