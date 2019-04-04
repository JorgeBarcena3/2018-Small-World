using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool gameIsPlaying = false;
    public GameOverScript gameOver;
    public MeteoroSpawner meteoro;
    public PlayerController player;
    public Score score;
    public UI ui;
    public MainMenu menu;

    // Use this for initialization
    void Start()
    {



    }

    private bool sePuedeLLamarAEndGame = false;

    // Update is called once per frame
    void Update()
    {

        Debug.Log(gameIsPlaying);

        if (!gameIsPlaying && sePuedeLLamarAEndGame)
        {
            endGame();
            sePuedeLLamarAEndGame = false;
            return;

        }

    }

    public void endGame()
    {
        //See panel
        gameOver.seePanel(true);

        //UI
        ui.DesactivateUI();

        //System
        games++;


    }

    public void GoToMenu()
    {
        //Hidde the panel
        gameOver.seePanel(false);

        menu.SetMenu();


    }

    private int games = 0;

    public void restartGame()
    {
        if (games == 0) {

            //System starts
            gameIsPlaying = true;
            sePuedeLLamarAEndGame = true;


            //Meteoro
            meteoro.clearMeteores();

            //Player
            player.restartPosition();


            //UI
            ui.activateUI();

            //MainMenu
            menu.UnsetMenu();



        }
        else
        {

            //System starts
            gameIsPlaying = true;
            sePuedeLLamarAEndGame = true;

           

            //Meteoro
            meteoro.clearMeteores();

            //Player
            player.restartPosition();

            //Score
            score.saveScore();
            score.restartScore();

            //UI
            ui.activateUI();

            //MainMenu
            menu.UnsetMenu();
        }



    }

    public void pauseGame()
    {


        Time.timeScale = 0;

    }

    public void reanudeGame()
    {

        Time.timeScale = 1;
    }

    public void twitter()
    {

        Application.OpenURL("https://twitter.com/Jorge_barcena3");
    }
}
