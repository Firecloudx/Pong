using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public Rigidbody2D rb;
    public float ySpeed;
    public float xSpeed;
    // Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        ySpeed = -5.0f;
        xSpeed = Random.Range(-3f, 3f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        rb.velocity = new Vector2(xSpeed, ySpeed);
	}

    

    

    
}
