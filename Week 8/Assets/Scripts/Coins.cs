using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private ScorekeeperScript scoreKeeper;

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "PlayerBlue")
        {
            Destroy(gameObject);
            scoreKeeper.OnPickupBlue();
        }
        else
        {
            Destroy(gameObject);
            scoreKeeper.OnPickupRed();
        }
    }

    void Start()
    {
        scoreKeeper = GameObject.Find("_ScoreKeeper").GetComponent<ScorekeeperScript>();
    }

    void Update()
    {
        
    }
}
