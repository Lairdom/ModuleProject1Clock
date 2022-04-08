using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject kello;

    
    void Instantiation()
    {
        int frames = Time.frameCount;
        if (frames % 600 == 0) {
            Instantiate(kello, new Vector3(0, 15, -2), Quaternion.Euler(0f,-30f,0f));
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 10)
            Instantiation();
        //Debug.Log((int)Time.time);
    }
}
