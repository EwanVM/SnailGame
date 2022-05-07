using TMPro;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float time = 0;
    private float roundSeconds;
    private bool GameOver = false;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI gameOver;
    public TextMeshProUGUI scoreText;
    public GameObject Spawner;
    public GameObject Snail;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    { // makes the timer in top left of screen count up in seconds
        while (GameOver == false)
        {
            time += Time.deltaTime;
            roundSeconds = (float)Math.Round(time, 0);
            timerText.text = "Time (Seconds): " + roundSeconds;
        }

        //scoreText.text ="Your score is " + roundSeconds; **Error**
        
        if (Snail == null)
        {
            gameOver.gameObject.SetActive(true);
            timerText.gameObject.SetActive(false);
            scoreText.gameObject.SetActive(true);
            Destroy(Spawner);
        }

    }
}
