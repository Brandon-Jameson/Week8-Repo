using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorekeeperScript : MonoBehaviour
{
    [SerializeField] private int onPickScore;
    private int score;
    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    public void OnPickup()
    {
        score += onPickScore;
        Debug.Log("Score: " + score);
    }

}
