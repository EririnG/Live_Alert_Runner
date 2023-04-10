using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public float ob = 1;

    public float Level(int score)
    {
        int defaultSpeed = -5;
        int increSpeed = (score * -1) / 100;
        if (increSpeed < -5)
            increSpeed = -5;

        return defaultSpeed + increSpeed;
    }

  

    // Update is called once per frame
    void Update()
    {
        ob -= Time.deltaTime * 0.1f; 
        transform.position += new Vector3(1.0f,0.0f,0.0f)*Time.deltaTime*ob;
    }
}
