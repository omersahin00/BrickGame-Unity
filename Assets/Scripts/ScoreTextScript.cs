using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText.text = "";

        if (GameStatics.isWon)
        {
            int seconds = Mathf.FloorToInt(GameStatics.finishTime % 60);
            int milliseconds = Mathf.FloorToInt(GameStatics.finishTime * 1000 % 1000);

            scoreText.text = "Finish Time: " + seconds.ToString() + "." + milliseconds.ToString();
        }
    }
}
