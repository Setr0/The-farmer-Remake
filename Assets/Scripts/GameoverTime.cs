using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameoverTime : MonoBehaviour
{
    public Text gameoverTime;

    void Update()
    {
        gameoverTime.text = $"Your time: {Stopwatch.time}";
    }
}
