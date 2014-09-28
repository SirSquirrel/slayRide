using UnityEngine;
using System.Collections;

public class santa_movement : MonoBehaviour {

	private Animator animator;
	public Transform player;

	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		this.animationUpdate ();
	}

	void animationUpdate()
	{
		player = GameObject.Find("Player").transform;
		var heading = player.position - transform.position;


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
}
