using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiggyEnemyTopMovement : MonoBehaviour
{
    Vector2 start;
    public float speed;

    void Start()
    {
        start = transform.position;
    }

    void Update()
    {
        if(transform.position.y > -21)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
        else
        {
            transform.position = start;
        }
    }
}
