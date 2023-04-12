using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public SpriteRenderer renderer;
    public Collider2D collider2D;
    // Start is called before the first frame update
    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
        collider2D = GetComponent<Collider2D>();
    }

  
    void Update()
    {
        
    }
}
