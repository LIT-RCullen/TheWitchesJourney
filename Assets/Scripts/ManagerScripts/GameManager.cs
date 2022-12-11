using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject enemies;
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
        Destroy(enemies);
    }
}
