using UnityEngine;
using System.Collections;

public class survival_menu : MonoBehaviour {
	
		void OnGUI()
		{
			const int buttonWidth = 150;
			const int buttonHeight = 60;
			
			// Determine the button's place on screen
			// Center in X, 2/3 of the height in Y
			Rect buttonRect = new Rect(
				Screen.width / 2 - (buttonWidth / 2),
			    (2 * Screen.height / 5) - (buttonHeight / 2),
				buttonWidth,
				buttonHeight
				);
			
			// Draw a button to start the game
			if(GUI.Button(buttonRect,"Survival"))
			{
				Application.LoadLevel("Survival");
			}
		}
	}
