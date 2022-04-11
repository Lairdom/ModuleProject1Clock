using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject kello;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int frames = Time.frameCount;
        if (Time.time > 10 && frames % 600 == 0)
            //Instantiate(kello, new Vector3(0, 15, -2), Quaternion.Euler(0f,-30f,0f));
            Instantiate(kello, new Vector3(Random.Range(-5,5), 15, Random.Range(-2,2)), Quaternion.Euler(0f,Random.Range(-30,30),0f));
        //Debug.Log((int)Time.time);
    }
}
