using UnityEngine;
using System.Collections;

public class mapAdvance : MonoBehaviour {
	public GameObject[] enemyList ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		enemyList = GameObject.FindGameObjectsWithTag("enemy");
		if(enemyList.GetLength(0) == 0)
		{
			Application.LoadLevel(Application.loadedLevel +1);
		}

	}
}
