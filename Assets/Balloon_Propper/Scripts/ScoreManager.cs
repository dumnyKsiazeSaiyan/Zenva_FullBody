using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI displayScoreText;

    private int gameScore = 0;

    private void Start()
    {
        UpdateScoreText();
    }

    public void AddScore (int scoreToAdd)
    {
        gameScore += scoreToAdd;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        displayScoreText.text = "Score: " + gameScore.ToString();
    }
}
