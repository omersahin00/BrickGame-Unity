using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private Timer timer;

    void Update()
    {
        timer = FindAnyObjectByType<Timer>();
        FinishGameControl();
    }

    private void FinishGameControl()
    {
        if (GameStatics.brickCount <= 0)
        {
            GameStatics.finishTime = timer.totalTime - timer.currentTime;
            GameStatics.isWon = true;
            GameStatics.isGameRunning = false;
        }

        if (!GameStatics.isGameRunning)
        {
            SceneManager.LoadScene("FinishGameScene");
        }
    }
}
