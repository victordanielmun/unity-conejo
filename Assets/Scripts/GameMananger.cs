using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameMananger : MonoBehaviour
{
    public static GameMananger instance;
    bool gameOver = false;
    int score = 0;
    public TMP_Text scoreText;
    public TMP_Text scoreTextPanel;
    public GameObject gameOverPanel;
    public AudioSource audioClic;
    public AudioSource audioDie;
    public AudioSource audioBackground;


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
        audioBackground.volume = 0.25f;
        audioDie.Play();
        GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().StopSpawning();
        GameObject.Find("EnemySpawner1").GetComponent<EnemySpawner1>().StopSpawning();
        GameObject.Find("EnemySpawner2").GetComponent<EnemySpawner2>().StopSpawning();
        scoreTextPanel.text = "Tu Puntaje es : " + score;
        gameOverPanel.SetActive(true);
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
            print(score);
        }
    }

    public void MainMenu()
    {
        audioClic.Play();
        audioBackground.Stop();
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        audioClic.Play();
        audioClic.Play();
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene("Game");
    }
}
