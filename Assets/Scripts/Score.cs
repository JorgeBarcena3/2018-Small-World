using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public float score = 0;

    private GameManager gm;

    // Use this for initialization
    void Start () {
       // getScore();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private float time;

	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if (gm.gameIsPlaying && time >= 0.1f)
        {
            score++;
            time = 0;
        }
		
	}


    public void restartScore() {

        score = 0;
    }

    public void setScore(float a)
    {

        score = a;
    }

    public void saveScore() {

        PlayerPrefs.SetFloat("Score", score);
    }

    public void getScore() {

        score = PlayerPrefs.GetFloat("Score");
    }
}
