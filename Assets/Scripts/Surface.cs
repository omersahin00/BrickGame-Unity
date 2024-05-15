using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surface : MonoBehaviour
{
    private bool isHorizontalSurface;
    private BallScript ballScript;

    void Start()
    {
        ballScript = FindAnyObjectByType<BallScript>();

        if (gameObject.name.Contains("Left") || gameObject.name.Contains("Right"))
        {
            isHorizontalSurface = true;
        }
        else if (gameObject.name.Contains("Up") || gameObject.name.Contains("Down"))
        {
            isHorizontalSurface = false;
        }
        else
        {
            Debug.LogError("Surface name error!");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isHorizontalSurface)
        {
            ballScript.transformX *= -1;
        }
        else
        {
            ballScript.transformY *= -1;
        }
    }
}
