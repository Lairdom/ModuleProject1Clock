using System;
using UnityEngine;

public class Clock : MonoBehaviour 
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;
    // float timeTaken;
    // float duration = 1;

    [SerializeField] Transform hoursPivot, minutesPivot, secondsPivot;
    // float oldPivot, newPivot;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(DateTime.Now);
        TimeSpan time = DateTime.Now.TimeOfDay;
        // timeTaken = Time.time;
        // oldPivot = secondsToDegrees * (int)time.TotalSeconds-1;
        // newPivot = secondsToDegrees * (int)time.TotalSeconds;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        // secondsPivot.localRotation = Quaternion.Euler(
            // 0f, 0f, Mathf.LerpAngle(oldPivot, newPivot, timeTaken/duration));
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (int)time.TotalSeconds);
        
        // Debug.Log(secondsToDegrees+", "+(time.TotalSeconds-1)+" "+time.TotalSeconds);
        // float seconds = (float)Math.Floor(time.TotalSeconds);
        // float remainer = Mathf.Lerp(0,1,Mathf.Atan((float)time.Seconds))
        // func=Mathf.LerpAngle(startvalue,endvalue,time/duration)
        // Mathf.LerpAngle(5f,15f,0) -> 5f alkuarvo
        // Mathf.LerpAngle(5f,15f,0.5) -> 10f puoliväli
        // Mathf.LerpAngle(5f,15f,1) -> 15f loppuarvo
        
    }
}
