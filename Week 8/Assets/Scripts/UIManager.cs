using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    private ScorekeeperScript scoreKeeper;
    private int blueScore;
    private int redScore;
    private TMP_Text scoreTextBlue;
    private TMP_Text scoreTextRed;
    private void Start()
    {
        scoreKeeper = GameObject.Find("_ScoreKeeper").GetComponent<ScorekeeperScript>();
        scoreTextBlue = GameObject.Find("ScoreTextBlue").GetComponent<TMP_Text>();
        scoreTextRed = GameObject.Find("ScoreTextRed").GetComponent<TMP_Text>();
    }

    private void Update()
    {
        blueScore = scoreKeeper.BlueScore;
        redScore = scoreKeeper.RedScore;
        scoreTextBlue.text = "Player 1 Score: " + blueScore;
        scoreTextRed.text = "Player 2 Score: " + redScore;
    }
}
