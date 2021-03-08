using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public static PlayerMove instance;
    private Rigidbody2D rb;
    public float speed;

    public float newPos;
    public Vector2 playerStart;
    private void Start()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
        playerStart = transform.position;
        Debug.Log(playerStart);
        newPos = transform.position.x;
    }

    private void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            newPos+= Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            newPos-= Time.deltaTime * speed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0,12), ForceMode2D.Impulse);
        }

        transform.position = new Vector2(newPos, transform.position.y);
    }
}
