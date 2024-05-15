using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLine : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {            
            Destroy(collision.gameObject);
            GameStatics.isWon = false;
            GameStatics.isGameRunning = false;
        }
    }
}
