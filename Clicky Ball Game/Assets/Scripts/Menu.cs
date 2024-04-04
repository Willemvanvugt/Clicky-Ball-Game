using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public static string playerNameInput;

    public KeyCode returnToMenuKey;

    private void Update()
    {
        if (Input.GetKeyDown(returnToMenuKey))
        {
            ReturnToMenu();
        }
    }

    public void ReadPlayerName(string playerNameString)
    {
        playerNameInput = playerNameString;
        Debug.Log("Player name = " + playerNameString);
    }

    public void LoadGame()
    {
        Settings.GameMode();
        SceneManager.LoadScene(1);
    }

    public void ReturnToMenu()
    {
        Settings.MenuMode();
        SceneManager.LoadScene(0);

    }

    public void CloseGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
