using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {

	public Transform enemy;
	private float Timer;
	public float delay = 0f;
	float refreshTime;

	void Start () {
		refreshTime = 0f;
	}

	//Timer increments
	void Awake() {
		Timer = Time.time + 3;
		refreshTime = refreshTime + 1;
	}

	void FixedUpdate()
	{
		refreshTime = refreshTime + 0.01f;
		}
	
	void Update() {
		if (Timer < Time.time && refreshTime>delay) { //This checks wether real time has caught up to the timer
			Instantiate(enemy, transform.position, transform.rotation); //This spawns the emeny
			Timer = Time.time + 3; //This sets the timer 3 seconds into the future
		}
	}
}
