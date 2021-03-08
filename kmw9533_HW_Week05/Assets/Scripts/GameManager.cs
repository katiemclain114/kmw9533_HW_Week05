using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int coinScore;
    public bool level01Complete = false;

    private void Start()
    {
        instance = this;
    }
}
