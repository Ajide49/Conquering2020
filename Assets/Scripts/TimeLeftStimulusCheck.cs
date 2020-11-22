using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeLeftStimulusCheck : MonoBehaviour
{
    public TextMeshProUGUI text;
    public static float timeLeft = 10f;
    public AudioSource background;
    // Start is called before the first frame update
    void Start()
    {
        background.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (StimulusCheckScore.score > 10)
        {
            //win game!
        }
        //Debug.Log(timeLeft);
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
            background?.Pause();
        }
        text.text = "Time left: " + Mathf.Round(timeLeft);
    }
}
