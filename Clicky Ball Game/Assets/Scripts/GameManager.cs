using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;

    public TextMeshProUGUI scoreText;

    private void Start()
    {
        UpdateScore(0);
        score = 0;
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = Menu.playerNameInput + "'s score: " + score;
    }

}
