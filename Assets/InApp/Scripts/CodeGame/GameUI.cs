using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using RObo;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum State
{
    Runing, Stop
}

public class GameUI : Singleton<GameUI>
{
    public Button back;
    public Button back1;
    public Button menu;

    public GameObject lose;

    public State currentState = State.Stop;

    
    // Start is called before the first frame update
    void Start()
    {
        back?.onClick.AddListener(ExitGame);
        back1?.onClick.AddListener(ExitGame);
        menu?.onClick.AddListener(RestartGame);
        
        //SetState(State.Stop);
    }
    

    
    private void ExitGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ShowLose()
    {
        GameController.Instance.SetState(StateGame.Pause);
        lose.SetActive(true);
    }

    public void RestartGame()
    {
        GameDataManager.Instance.ResetLevel();
        SceneManager.LoadScene("Game");
    }
    

    //private float duration = 1f;

    /*public void SetState(State state)
    {
        currentState = state;
    }*/
}