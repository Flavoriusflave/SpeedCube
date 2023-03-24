using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public static float currentTime { get; private set; }
    private bool TimerOn = false;

    [SerializeField]
    private TextMeshPro TimerText;
    [SerializeField]

    // Update is called once per frame
    void Update()
    {
        if(TimerOn)
            currentTime += Time.deltaTime;
    }

    private void FixedUpdate()
    {
        if(TimerOn)
            UpdateTimerText();
    }

    void UpdateTimerText()
    {
        float seconds = Mathf.Round(currentTime * 100.0f) / 100.0f;

        TimerText.text = seconds + " seconds";
    }

    //reset
    public void ResetTimer()
    {
        currentTime = 0f;
    }
    //start
    public void StartTimer()
    {
        TimerOn = true;
    }
    //stop
    public void StopTimer()
    {
        TimerOn = false;
    }
}
