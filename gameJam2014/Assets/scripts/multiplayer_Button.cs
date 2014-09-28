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
			Screen.width / 2 - (buttonWidth / 2) +200,
			(Screen.height / 2) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		
		GUIStyle invisibox;
		invisibox = new GUIStyle ();
		//invisibox.alignment = TextAnchor.MiddleCenter;
		//invisibox.normal.textColor = new Color(0,100,0);
		//invisibox.fontSize = 30;
		
		if(GUI.Button(buttonRect,"",invisibox))
		{
			Application.LoadLevel("multSurvival");
		}
	}
}
