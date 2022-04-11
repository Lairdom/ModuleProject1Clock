using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerppiScripti : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(10f,-5f,5f);    //Moves object to coordinates x,y,z (initial position: 10f,-5f,0f)
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        float duration = 1;
        transform.position = new Vector3(10f,-5f,Mathf.Lerp(0f,5f,time/duration));
        transform.rotation = Quaternion.Euler(0f,0f,Mathf.Lerp(0f,60f,time/duration));
        // float seconds = (float)Math.Floor(time.TotalSeconds);
        // float remainer = Mathf.Lerp(0,1,Mathf.Atan((float)time.Seconds))
        // func=Mathf.LerpAngle(startvalue,endvalue,time/duration)
        // Mathf.LerpAngle(5f,15f,0f) -> 5f alkuarvo
        // Mathf.LerpAngle(5f,15f,0.5f) -> 10f puoliväli
        // Mathf.LerpAngle(5f,15f,1f) -> 15f loppuarvo

    }
}
