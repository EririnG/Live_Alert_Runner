using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinity_Region : MonoBehaviour
{
    Rigidbody2D RB;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(transform.position.x<-12)
        {
            transform.position += new Vector3(24.0f,0.0f,0.0f);
        }
    }
}
