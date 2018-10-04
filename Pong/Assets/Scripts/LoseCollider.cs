using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

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
        ball.transform.position = new Vector3(13f, 7.8f, 0f);
        ball.xSpeed += Random.Range(-1f, 1f);
        
    }
}
