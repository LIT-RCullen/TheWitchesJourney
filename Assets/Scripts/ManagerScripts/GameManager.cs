using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;

    public static GameManager instance;

    void Awake()
    {
        instance = this;
        gameOver.SetActive(false);
    }

    public void killPlayer()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
