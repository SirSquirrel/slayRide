using UnityEngine;
using System.Collections;

public class multEnemy : MonoBehaviour {
	//enemy that moves to player when close enough
	
	public float speed = 6f;
	public Transform player;
	public Transform player2;
	public float enemySight = 1000f;
	private Animator animator;
	public AudioClip[] clips;
	public AudioSource source;
	int rand;
	
	// Use this for initialization
	void Start()
	{
		rand = Random.Range (0, clips.Length);
		source.clip = clips [rand];
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		if(!KillCountMult.playerKilled || !KillCountMult.player2Killed)
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
			Face(player);
		}

		if(heading2.magnitude < heading1.magnitude){
			toTransform(heading2,player2);
			Face (player2);
		}
		}

		if(KillCountMult.playerKilled)
		{
			player2 = GameObject.Find("Player2").transform;
			var heading2 = player2.position - transform.position;
			
			var distance2 = heading2.magnitude;

			toTransform(heading2,player2);
			Face(player2);
		}

		if(KillCountMult.player2Killed)
		{
			player = GameObject.Find("Player").transform;
			var heading1 = player.position - transform.position;
			
			var distance1 = heading1.magnitude;
			toTransform(heading1,player);
			Face(player);
		}
		}
		
		StartCoroutine("HoHo");
	}

	void Face(Transform cPlayer)
	{
		var heading = cPlayer.position - transform.position;
		
		
		if (heading.x > 0 && heading.x > heading.y) {
			animator.SetInteger ("Direction", 3);
		} else if (heading.x < 0 && heading.x < heading.y) {
			animator.SetInteger ("Direction", 1);
		} else if (heading.y < 0 && heading.x > heading.y) {
			animator.SetInteger ("Direction", 0);
		} else if (heading.y > 0 && heading.x < heading.y) {
			animator.SetInteger ("Direction", 2);
		} else if (heading.x == 0 && heading.y == 0) {
			animator.SetInteger ("Direction", 4);
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

	IEnumerator HoHo() {
		if (!source.isPlaying) {
			rand = Random.Range (0, clips.Length);
			source.clip = clips [rand];
			source.Play();
			yield return new WaitForSeconds(Random.Range(4.0f, 8.0f));
		}
	}
}
