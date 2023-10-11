using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    private ScorekeeperScript scoreKeeper;
    private int score;
    private TMP_Text scoreText;
    private void Start()
    {
        scoreKeeper = GameObject.Find("_ScoreKeeper").GetComponent<ScorekeeperScript>();
        scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
    }

    private void Update()
    {
        score = scoreKeeper.Score;
        scoreText.text = "Player 1 Score: " + score;
    }
}
