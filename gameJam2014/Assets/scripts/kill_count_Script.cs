using UnityEngine;
using System.Collections;

public class kill_count_Script : MonoBehaviour {

	public GUIText kText;
	public static int kills;
	void Start () {
		kills = 0;
	}


	// Update is called once per frame
	void Update () {
		kText.text = kills.ToString ();
	}
}
