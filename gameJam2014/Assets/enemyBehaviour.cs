using UnityEngine;
using System.Collections;

public class enemyBehaviour : MonoBehaviour
{
    //enemy that moves to player when close enough

    public float speed = 10f;
    public Transform player;
    public float enemySight = 1000f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        var heading = player.position - transform.position;

        var distance = heading.magnitude;
        var direction = heading / distance;

        if (heading.sqrMagnitude < enemySight * enemySight)
        {

        }

    }
}
