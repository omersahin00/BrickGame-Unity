using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject pedal;
    public float transformX, transformY;

    private void Start()
    {
        transformX = 5f;
        transformY = 10f;
        GameStatics.isGameRunning = true;
    }

    void Update()
    {
        transform.Translate(new Vector2(transformX, transformY) * Time.deltaTime);
    }
}
