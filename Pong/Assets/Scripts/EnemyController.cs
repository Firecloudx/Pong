using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private BallController ball;

    // Use this for initialization
    void Start()
    {
        ball = FindObjectOfType<BallController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(ball.transform.position.x, transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        ball.xSpeed += Random.Range(-2f, 2f);
        ball.ySpeed = -ball.ySpeed;
    }
}
