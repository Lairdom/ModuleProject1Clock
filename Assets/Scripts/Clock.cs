using System;
using UnityEngine;

public class Clock : MonoBehaviour 
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;
    
    [SerializeField] Transform hoursPivot, minutesPivot, secondsPivot;

    float timer;
    public float roundTimer = 60f;
    

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(DateTime.Now);
        TimeSpan time = DateTime.Now.TimeOfDay;

        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (int)time.TotalSeconds);

    }
}
