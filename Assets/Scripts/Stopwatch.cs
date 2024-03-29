using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    float timer;
    float seconds;
    float minutes;
    float hours;
    public static string time;

    public Text stopWatchText;

    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        minutes = (int)(timer / 60);
        hours = (int)(timer / 3600);

        time = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");

        stopWatchText.text = $"Time: {time}";
    }
}
