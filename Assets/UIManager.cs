using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Button = UnityEngine.UI.Button;

public class UIManager : MonoBehaviour
{
    public Button startButton;
    public Button menuButton;
    public Button quitButton;

    //public void Awake()
    //{
    //    Debug.Log("Se carga menu?");
    //}

    public void OnStartLevelButtonClicked()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Main scene loaded...");
    }

    public void OnExitButtonClicked()
    {
        Application.Quit();
    }

    public void OnMenuButtonClicked()
    {
        Debug.Log("Main menu");
    }
}
