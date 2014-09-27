using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {

	public Transform enemy;
	private float Timer;

	void Start () {
		
	}

	//Timer increments
	void Awake() {
		Timer = Time.time + 3;
	}
	
	void Update() {
		if (Timer < Time.time) { //This checks wether real time has caught up to the timer
			Instantiate(enemy, transform.position, transform.rotation); //This spawns the emeny
			Timer = Time.time + 3; //This sets the timer 3 seconds into the future
		}
	}
}
