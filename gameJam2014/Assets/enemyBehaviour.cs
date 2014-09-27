using UnityEngine;
using System.Collections;

public class enemyBehaviour : MonoBehaviour {
	//enemy that moves to player when close enough

	public float speed = 10f;
	public Transform player;
	float distance_to_player;
	public float enemySight = 500f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		distance_to_player = new Vector2(player.position,rigidbody2D.position);

			
			Vector2.MoveTowards(rigidbody2D.position,player.position,enemySight);
			
	}
}
