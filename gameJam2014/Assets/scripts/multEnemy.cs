using UnityEngine;
using System.Collections;

public class multEnemy : MonoBehaviour {
	//enemy that moves to player when close enough
	
	public float speed = 6f;
	public Transform player;
	public Transform player2;
	public float enemySight = 1000f;

	
	// Use this for initialization
	void Start()
	{
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		if(!KillCountMult.playerKilled&& !KillCountMult.player2Killed)
		{
		player = GameObject.Find("Player").transform;
		var heading1 = player.position - transform.position;
		
		var distance1 = heading1.magnitude;
		//var direction1 = heading1 / distance1;


		player2 = GameObject.Find("Player2").transform;
		var heading2 = player2.position - transform.position;
		
		var distance2 = heading2.magnitude;
		//var direction2 = heading2 / distance2;


		if(heading1.magnitude <= heading2.magnitude){
			toTransform(heading1,player);
		}

		if(heading2.magnitude < heading1.magnitude){
			toTransform(heading2,player2);
		}
		}

		if(KillCountMult.playerKilled)
		{
			player2 = GameObject.Find("Player2").transform;
			var heading2 = player2.position - transform.position;
			
			var distance2 = heading2.magnitude;

			toTransform(heading2,player2);
		}

		if(KillCountMult.player2Killed)
		{
			player = GameObject.Find("Player").transform;
			var heading1 = player.position - transform.position;
			
			var distance1 = heading1.magnitude;
			toTransform(heading1,player);
		}
		

	}

	void toTransform(Vector3 heading,Transform playa)
	{
		if (heading.sqrMagnitude < enemySight * enemySight)
		{
			float angle = Mathf.Atan2(heading.y, heading.x) * Mathf.Rad2Deg;
			Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
			
			//transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
			transform.position = Vector2.MoveTowards(rigidbody2D.position, new Vector2(playa.transform.position.x, playa.transform.position.y), Time.deltaTime * speed);
		}
	}

	//die on collision with sled
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.name == "Sled"){
			if(collision.relativeVelocity.magnitude>3)
			{
				Destroy(this.gameObject);
				
				KillCountMult.kills1 = KillCountMult.kills1 + 1;
			}
			
		}

		if(collision.gameObject.name == "Sled2"){
			if(collision.relativeVelocity.magnitude>3)
			{
				Destroy(this.gameObject);
				
				KillCountMult.kills2 = KillCountMult.kills2 + 1;
			}
			
		}

		if(collision.gameObject.name == "Player"){
			Destroy(collision.gameObject);
			KillCountMult.playerKilled = true;
		}

		if(collision.gameObject.name == "Player2"){
			Destroy(collision.gameObject);
			KillCountMult.player2Killed = true;

		}
	}
}
