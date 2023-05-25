using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMananger : MonoBehaviour
{
    public static GameMananger instance;
    bool gameOver = false;
    int score = 0;

    private void Awake() 
        {
        if (instance == null)
            {
                instance = this;
            }
        }

    public void GameOver()
    {
        gameOver = true;

        GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().StopSpawning();
    }

    public void IncrementScore()
    {
        score++;
        print(score);
    }
}
