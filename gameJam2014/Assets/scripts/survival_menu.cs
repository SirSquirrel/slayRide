using UnityEngine;
using System.Collections;

public class survival_menu : MonoBehaviour {
	
		void OnGUI()
		{
			const int buttonWidth = 150;
			const int buttonHeight = 60;
			
			Rect buttonRect = new Rect(
				Screen.width / 2 - (buttonWidth / 2),
			    (2 * Screen.height / 5) - (buttonHeight / 2),
				buttonWidth,
				buttonHeight
				);
			
			if(GUI.Button(buttonRect,"Survival!"))
			{
				Application.LoadLevel("Survival");
			}
		}
	}
