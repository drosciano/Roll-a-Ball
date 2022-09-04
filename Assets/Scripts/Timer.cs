using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float startTime;
    public GameObject pickUp;
    public GameObject loseTextObject;
    private bool finnished = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime += Time.time;
        loseTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (finnished)
            return;

        float t = startTime - Time.time;
        if (t <= 0)
        {
            t = 0;
            pickUp.gameObject.SetActive(false);
            loseTextObject.SetActive(true);

        }
        string seconds = (t % 60).ToString("f2");

        timerText.text = seconds;


    }

    public void Finnish()
    {
        finnished = true;
    }
}
