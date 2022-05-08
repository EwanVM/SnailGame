using TMPro;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float time; // Variable for time
    private float roundSeconds; // Variable for rounding time to the nearest whole number
    private bool GameOver = false; // The starting game state will be GameOver = false
    public TextMeshProUGUI timerText; // Timer text
    public TextMeshProUGUI gameOver; // Game over text
    public TextMeshProUGUI scoreText; // Score text
    public GameObject Spawner; // Links the object which controls the spawner with the game manager script which enables the game manager to alter it
    public GameObject Snail; // Links the player with the script so the script can detect when it is altered
    
    // Update is called once per frame
    void Update()
    { // makes the timer count up in seconds
        if (GameOver == false)
        {
            time += Time.deltaTime;
        }

        roundSeconds = (float)Math.Round(time, 0);
        timerText.text = "Time: " + roundSeconds;
        scoreText.text ="Your score is " + roundSeconds;

        // if the game is over, the game over text and the score text will appear and the timer text will disappear
        if (GameOver == true)
        {
            gameOver.gameObject.SetActive(true);
            timerText.gameObject.SetActive(false);
            scoreText.gameObject.SetActive(true);
            Destroy(Spawner);
        }

     // If the snail object is no longer in the game (null) the game will enter the game over state
        if (Snail == null)
        {          
            GameOver = true;            
        }
    }
}
