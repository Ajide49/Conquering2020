using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeftProtest : MonoBehaviour
{
    Text text;
    public static float timeLeft = 7f;
    public AudioSource background;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        background.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.transform.position.x);
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0){
            timeLeft = 0;
            background.Pause();
            if (player.transform.position.x > .035){
                //Debug.Log("hello");
                //win game
            }
        }
        text.text = "Time left: " + Mathf.Round(timeLeft);
    }
}
