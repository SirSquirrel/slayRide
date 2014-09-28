using UnityEngine;
using System.Collections;

public class sEnemy : MonoBehaviour {
	//enemy that moves to player when close enough
	
	public float speed = 6f;
	public Transform player;
	public float enemySight = 1000f;
	
	// Use this for initialization
	void Start()
	{
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		player = GameObject.Find("Player").transform;
		//move and face towards player
		var heading = player.position - transform.position;
		
		var distance = heading.magnitude;
		var direction = heading / distance;
		
		if (heading.sqrMagnitude < enemySight * enemySight)
		{
			float angle = Mathf.Atan2(heading.y, heading.x) * Mathf.Rad2Deg;
			Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
			
			//transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
			transform.position = Vector2.MoveTowards(rigidbody2D.position, new Vector2(player.transform.position.x, player.transform.position.y), Time.deltaTime * speed);
		}
		
		
	}
	
	//die on collision with sled
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.name == "Sled"){
			if(collision.relativeVelocity.magnitude>3)
			{
				Destroy(this.gameObject);
		
				kill_count_Script.kills = kill_count_Script.kills + 1;
			}
			
		}
		
		if(collision.gameObject.name == "Player"){
			Destroy(player.gameObject);
			Application.LoadLevel("menu");
		}
	}
}
