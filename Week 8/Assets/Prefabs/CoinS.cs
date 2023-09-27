using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinS : MonoBehaviour
{

    private ScorekeeperScript scoreKeeper;

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            scoreKeeper.OnPickup();

        }


    }

    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = GameObject.Find("_ScoreKeeper").GetComponent<ScorekeeperScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
