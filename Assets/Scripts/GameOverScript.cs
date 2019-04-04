using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScript : MonoBehaviour
{

    public TextMeshProUGUI finalScore;
    public Score sc;
    public Animator anim;


    private void setScore()
    {

        finalScore.text = sc.score.ToString();

    }

    public void seePanel(bool aux)
    {


        if (aux)
        {
            setScore();
            anim.ResetTrigger("GameStart");
            anim.SetTrigger("GameOver");

        }
        if (!aux)
        {
            anim.ResetTrigger("GameOver");
            anim.SetTrigger("GameStart");


        }
    }
}
