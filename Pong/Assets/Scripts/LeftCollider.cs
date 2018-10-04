using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCollider : MonoBehaviour {

    private BallController ball;
    
    // Use this for initialization
	void Start ()
    {
        ball = FindObjectOfType<BallController>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //transform.position = new Vector3(0f, 2f, 0f);
        ball.xSpeed = -ball.xSpeed;
    }
}
