using UnityEngine;
using System.Collections;

public class jingleSled : MonoBehaviour {

	AudioSource audio1;
	AudioSource audio2;

	void Start () {
		AudioSource[] audios = GetComponents<AudioSource>();
		audio1 = audios[0];
		audio2 = audios[1];
	}
	
	// Update is called once per frame
	void Update () {
	if (rigidbody2D.velocity.magnitude > 3) {
			if(!audio1.isPlaying)
			{
			audio1.Play();
			}
				}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.name == "enemy"){
			
			if(collision.relativeVelocity.magnitude>3)
			{
				audio2.Play();
			}
			
		}

}
}

