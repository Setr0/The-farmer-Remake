using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CingyEnemyRightMovement : MonoBehaviour
{
    Vector2 start;
    public float speed;

    void Start()
    {
        start = transform.position;
    }

    void Update()
    {
        if (transform.position.x > -14)
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = start;
        }
    }
}
