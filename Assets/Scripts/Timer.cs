using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime +=  Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        float t = startTime - Time.time;
        if (t <= 0)
        {
            t = 0;
        }
        string seconds = (t % 60).ToString("f2");
        
        timerText.text =  seconds;

        
    }
}
