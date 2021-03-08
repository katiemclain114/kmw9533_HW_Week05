using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector2 startPos;
    public float speed;
    public Vector2 moveLength;
    private bool gotToOne = false;

    private Vector2 newPos;
    [Range(0,1)]
    public float t;
    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        if (gotToOne)
        {
            if (t >= 0)
            {
                t -= Time.deltaTime * speed;
            }
            else
            {
                gotToOne = false;
            }
        }
        else
        {
            if (t <= 1)
            {
                t += Time.deltaTime * speed;
            }
            else
            {
                gotToOne = true;
            }
        }

        //t = Mathf.Clamp01(t);
        newPos = Vector2.Lerp(startPos, startPos + moveLength, t);
        transform.position = newPos;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        string player = other.tag;
        if (player == "Player")
        {
            PlayerMove.instance.newPos = PlayerMove.instance.playerStart.x;
        }
    }
}