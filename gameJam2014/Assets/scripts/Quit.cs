using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	void OnGUI()
	{
		const int buttonWidth = 84;
		const int buttonHeight = 60;

		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			Screen.height/2,
			buttonWidth,
			buttonHeight
			);

		if(GUI.Button(buttonRect,"Quit!"))
		{
			Application.Quit();
		}
	}
}
