using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        string player = other.tag;
        if (player == "Player")
        {
            GameManager.instance.coinScore++;
            Destroy(gameObject);
        }
    }
}
