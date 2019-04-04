using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UI : MonoBehaviour {

    public GameObject score;
    private TextMeshProUGUI scoreText;
    public Score scoreManager;
    public Animator anim;
    

	// Use this for initialization
	void Start () {

        scoreText = GameObject.Find("ScoreText").GetComponentInChildren<TextMeshProUGUI>();
		
	}

    public void activateUI() {

        anim.ResetTrigger("Out");
        anim.SetTrigger("In");
    }

    public void DesactivateUI()
    {
        anim.ResetTrigger("In");
        anim.SetTrigger("Out");
    }

    // Update is called once per frame
    void Update () {

        scoreText.text = scoreManager.score.ToString();

	}
}
