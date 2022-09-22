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
    public TextMeshProUGUI timerText; 
    public TextMeshProUGUI gameOver; 
    public TextMeshProUGUI scoreText; 
    public GameObject Spawner; // Links spawner with game manager script
    public GameObject Snail; // Links snail with game manager script
    
    // Update is called once per frame
    void Update()
    { // makes the timer count up in seconds
        if (GameOver == false)
        {
            time += Time.deltaTime;
        }

        roundSeconds = (float)Math.Round(time, 0);
        timerText.text = "Time: " + time;
        scoreText.text ="Your score is " + roundSeconds;

        
     // If the snail object is no longer in the game (null) the game will enter the game over state
        if (Snail == null)
        {          
            GameOver = true;
            gameOver.gameObject.SetActive(true);
            timerText.gameObject.SetActive(false);
            scoreText.gameObject.SetActive(true);
            Destroy(Spawner);
        }
    }
}
