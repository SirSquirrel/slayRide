using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	void OnGUI()
	{
		const int buttonWidth = 150;
		const int buttonHeight = 60;

		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2) +400,
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
			Application.Quit();
		}
	}
}
