using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	void OnGUI()
	{
		const int buttonWidth = 150;
		const int buttonHeight = 60;

		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			Screen.height/2 +100,
			buttonWidth,
			buttonHeight
			);

		if(GUI.Button(buttonRect,"Quit!"))
		{
			Application.Quit();
		}
	}
}
