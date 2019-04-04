using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCollider : MonoBehaviour
{
    private GameManager gm;

    void Start() {

        gm = GameObject.Find("GameManager").GetComponent<GameManager>();


    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {

            gm.gameIsPlaying = false;

        }
    }
}
