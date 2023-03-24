using System.Collections;
using System.Collections.Generic;
using RObo;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasUI : Singleton<CanvasUI>
{
    public Image bg;
    
    public Button start, exit;

    public Button continueBut;
    // Start is called before the first frame update
    void Start()
    {
        start?.onClick.AddListener(NewGame);
        exit?.onClick.AddListener(ExitGame);
        continueBut?.onClick.AddListener(ContinueGame);
        
        SetBG(GameDataManager.Instance.bg[GameDataManager.Instance.playerData.currentBG]);
    }

    private void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void NewGame()
    {
        GameDataManager.Instance.ResetLevel();
        SceneManager.LoadScene("Game");
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetBG(Sprite sprite)
    {
        bg.sprite = sprite;
    }
}