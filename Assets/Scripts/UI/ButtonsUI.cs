using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsUI : MonoBehaviour
{
    private Move pControl;

    void Start()
    {
        pControl = PlayerManager.InstancePlayer.player.GetComponent<Move>();
    }

    public void ClickButtonAttack()
    {
        pControl.Attack();
    }

    public void ClickButtonDash()
    {
        pControl.Dash();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }

    public void returnToMM()
    {
        SceneManager.LoadScene(0);
    }
}
