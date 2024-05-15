using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private void Start()
    {
        GameStatics.brickCount += 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            GameStatics.brickCount--;
            Destroy(gameObject);
        }
    }
}
