using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCollider : MonoBehaviour {


    private BallController ball;

    // Use this for initialization
    void Start()
    {
        ball = FindObjectOfType<BallController>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ball.xSpeed += Random.Range(-0.5f, 0.5f);
        ball.xSpeed = -ball.xSpeed;
    }
}
