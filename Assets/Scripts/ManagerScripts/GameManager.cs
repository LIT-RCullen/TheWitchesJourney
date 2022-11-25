using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;
    #region Singleton

    public static GameManager instance;

    void Awake()
    {
        instance = this;
        gameOver.SetActive(false);
    }

    #endregion

    public void killPlayer()
    {
        gameOver.SetActive(true);
    }
}
