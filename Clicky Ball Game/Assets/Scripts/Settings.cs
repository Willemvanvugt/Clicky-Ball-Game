using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;

    void Start()
    {
        UpdatePlayerName();
    }

    public void UpdatePlayerName()
    {
        playerNameText.text = Menu.playerNameInput;
    }

    public static void MenuMode()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public static void GameMode()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
