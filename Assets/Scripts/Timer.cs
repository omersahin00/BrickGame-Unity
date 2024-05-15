using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float totalTime;
    public float currentTime;


    void Start()
    {
        if (totalTime == 0) totalTime = 40f;
        currentTime = totalTime;
    }

    void Update()
    {
        if (!GameStatics.isGameRunning) return;

        currentTime -= Time.deltaTime;

        int seconds = Mathf.FloorToInt(currentTime % 60);
        int milliseconds = Mathf.FloorToInt((currentTime * 1000) % 1000);

        timerText.text = string.Format("{0:00}:{1:000}", seconds, milliseconds);

        if (currentTime <= 0f)
        {
            currentTime = 0f;
            GameStatics.isWon = false;
            GameStatics.isGameRunning = false;
        }

        if (currentTime <= 10f)
        {
            timerText.color = Color.red;
        }
    }
}
