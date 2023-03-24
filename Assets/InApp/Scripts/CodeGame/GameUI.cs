using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using RObo;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameUI : Singleton<GameUI>
{
    public GameObject lose;
    public GameObject win;


    public void ExitGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ShowLose()
    {
        GameController.Instance.SetState(StateGame.Pause);
        lose.SetActive(true);
    }

    public void ShowWin()
    {
        GameController.Instance.SetState(StateGame.Pause);
        win.SetActive(true);
    }

    public void RestartGame()
    {
        GameDataManager.Instance.ResetLevel();
        SceneManager.LoadScene("Game");
    }

    public void UpLevel()
    {
        GameDataManager.Instance.NextLevel();
        SceneManager.LoadScene("Game");
    }

    public void PlayAgain()
    {
        if (GameDataManager.Instance.playerData.intDiamond > 0)
        {
            GameDataManager.Instance.playerData.SubDiamond(1);
        }

        SceneManager.LoadScene("Game");
    }
}