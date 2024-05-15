using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    BallScript ballScript;

    private void Start()
    {
        ballScript = FindAnyObjectByType<BallScript>();
    }

    void Update()
    {
        Vector3 farePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        transform.position = new Vector3(farePos.x, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 collisionPoint = collision.contacts[0].point;
        Vector3 originPosition = transform.position;
        float distanceX = collisionPoint.x - originPosition.x;

        if (ballScript.transformX <= 15f)
            ballScript.transformX += distanceX;
    }
}
