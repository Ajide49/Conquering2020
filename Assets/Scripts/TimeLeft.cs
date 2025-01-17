﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeft : MonoBehaviour
{
    Text text;
    public static float timeLeft = 5f;
    // Start is called before the first frame update
    public AudioSource background;
    void Start()
    {
        text = GetComponent<Text>();
        background.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(timeLeft);
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0){
            timeLeft = 0;
            background.Pause();
        }
        text.text = "Time left: " + Mathf.Round(timeLeft);
    }
}
