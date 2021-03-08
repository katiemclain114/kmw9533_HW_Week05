using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ASCIILevelLoader : MonoBehaviour
{
    public int xOffset;
    public int yOffset;
    
    public GameObject player;
    public GameObject floor;
    public GameObject enemy;
    public GameObject coin;
    public GameObject goal;

    const string DIR_LOGS = "/Logs";
    const string FILE_ASCII = DIR_LOGS + "/marioMaker.txt";
    public string FILE_PATH_ASCII;

    private void Start()
    {
        FILE_PATH_ASCII = Application.dataPath + FILE_ASCII;
        LoadLevel();
    }

    void LoadLevel()
    {
        string[] fileLines = File.ReadAllLines(FILE_PATH_ASCII);

        for (int y = 0; y < fileLines.Length; y++)
        {
            string lineText = fileLines[y];

            char[] characters = lineText.ToCharArray();

            for (int x = 0; x < characters.Length; x++)
            {
                char c = characters[x];
                GameObject newObj;

                switch (c)
                {
                    case 'p':
                        newObj = Instantiate<GameObject>(player);
                        break;
                    case 'f':
                        newObj = Instantiate<GameObject>(floor);
                        break;
                    case 'c':
                        newObj = Instantiate<GameObject>(coin);
                        break;
                    case '#':
                        newObj = Instantiate<GameObject>(enemy);
                        break;
                    case '*':
                        newObj = Instantiate<GameObject>(goal);
                        break;
                    default:
                        newObj = null;
                        break;
                }

                if (newObj != null)
                {
                    newObj.transform.position = new Vector2(x + xOffset, -y + yOffset);
                }
            }
        }
    }
}
