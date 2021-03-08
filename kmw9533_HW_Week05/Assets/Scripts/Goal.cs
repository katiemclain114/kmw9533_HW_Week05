using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        string player = other.tag;
        if (player == "Player")
        {
            GameManager.instance.level01Complete = true;
        }
    }
}
