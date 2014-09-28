﻿using UnityEngine;
using System.Collections;

public class enemyBehaviour : MonoBehaviour
{
    //enemy that moves to player when close enough

    public float speed = 6f;
    public Transform player;
    public float enemySight = 1000f;
	public AudioClip[] clips;
	public AudioSource source;
	int rand;

    // Use this for initialization
    void Start()
    {
		rand = Random.Range (0, clips.Length);
		source.clip = clips [rand];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		if (!puller_control.isDead) {
						player = GameObject.Find ("Player").transform;
						//move and face towards player
						var heading = player.position - transform.position;

						var distance = heading.magnitude;
						var direction = heading / distance;

						if (heading.sqrMagnitude < enemySight * enemySight) {
								float angle = Mathf.Atan2 (heading.y, heading.x) * Mathf.Rad2Deg;
								Quaternion q = Quaternion.AngleAxis (angle, Vector3.forward);

								//transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
								transform.position = Vector2.MoveTowards (rigidbody2D.position, new Vector2 (player.transform.position.x, player.transform.position.y), Time.deltaTime * speed);
						}
				}
		StartCoroutine("HoHo");
	}

	//die on collision with sled
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.name == "Sled"){

			if(collision.relativeVelocity.magnitude>3)
			{
			Destroy(this.gameObject);
			}

		}

		if(collision.gameObject.name == "Player"){
			puller_control.isDead = true;
			Destroy(player.gameObject);
			Application.LoadLevel("GameOver");
		}
	}

	//Coroutine to call the enemy's hohos.
	IEnumerator HoHo() {
		if (!source.isPlaying) {
			rand = Random.Range (0, clips.Length);
			source.clip = clips [rand];
			source.Play();
			yield return new WaitForSeconds(Random.Range(4.0f, 8.0f));
		}
	}
}
