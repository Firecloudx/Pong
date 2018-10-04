using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed;
    private Rigidbody2D rb;
    private BallController ball;

    // Use this for initialization
    void Start()
    {
        speed = 5.0f;
        rb = GetComponent<Rigidbody2D>();
        ball = FindObjectOfType<BallController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {

            rb.velocity = new Vector2(speed, 0f);

        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed, 0f);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }



       transform.position = new Vector3(Mathf.Clamp(transform.position.x, 5f, 20f), transform.position.y, 0f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        ball.xSpeed += Random.Range(-2f, 2f);
        ball.ySpeed = -ball.ySpeed;
    }
}
