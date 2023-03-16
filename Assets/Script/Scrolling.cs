using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public float ob = 1;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1.0f,0.0f,0.0f)*Time.deltaTime*ob ;
    }
}
