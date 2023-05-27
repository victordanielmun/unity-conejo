using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static MenuController instance;
    public AudioSource audioSource;

    public void Play()
    {
        audioSource.pitch = 1f;
        audioSource.volume = 1f;
        audioSource.Play();
        SceneManager.LoadScene("Game");
    }
}
