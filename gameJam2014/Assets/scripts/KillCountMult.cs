using UnityEngine;
using System.Collections;

public class KillCountMult : MonoBehaviour {
	
	public GUIText kText;
	public static int kills1;
	public static int kills2;
	public static bool playerKilled;
	public static bool player2Killed;

	void Start () {
		kills1 = 0;
		kills2 = 0;
		playerKilled = false;
		player2Killed = false;
	}
	
	
	// Update is called once per frame
	void Update () {
		kText.text = "P1:" + kills1.ToString() + System.Environment.NewLine + "P2:" + kills2.ToString();

		if (playerKilled && player2Killed) {
			Application.LoadLevel ("GameOver");
		}
	}
}
