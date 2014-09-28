﻿using UnityEngine;
using System.Collections;

public class MenuPlay : MonoBehaviour {
	
		void OnGUI()
		{
			const int buttonWidth = 84;
			const int buttonHeight = 60;
			
			// Determine the button's place on screen
			// Center in X, 2/3 of the height in Y
			Rect buttonRect = new Rect(
				Screen.width / 2 - (buttonWidth / 2),
			    Screen.height/3 - (buttonHeight / 2) -50,
				buttonWidth,
				buttonHeight
				);
			
			// Draw a button to start the game
			if(GUI.Button(buttonRect,"Start!"))
			{
				Application.LoadLevel("ok this is a map");
			}
		}
	}
