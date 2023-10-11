using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorekeeperScript : MonoBehaviour
{
    [SerializeField] private int onPickScore;
    private int blueScore;
    public int BlueScore
    {
        get { return blueScore; }
        set { blueScore = value; }
    }
    private int redScore;
    public int RedScore
    {
        get { return redScore; }
        set { redScore = value; }
    }

    public void OnPickupBlue()
    {
        blueScore += onPickScore;
        Debug.Log("Blue player collected");
    }

    public void OnPickupRed()
    {
        redScore += onPickScore;
         Debug.Log("Red player collected");
    }

}
