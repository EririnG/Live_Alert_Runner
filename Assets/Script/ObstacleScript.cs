using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleScript : MonoBehaviour
{
    // Start is called before the first frame update

    public SpriteRenderer renderer;
    public Collider2D collider2D;

    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
        collider2D = GetComponent<Collider2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -12)
        {
            transform.position += new Vector3(24.0f, 0.0f, 0.0f);
            if (Random.Range(0, 2) == 1)
            {
                renderer.enabled = true;
                collider2D.enabled = true;
            }
            else
            {
                renderer.enabled = false;
                collider2D.enabled = false;
            }
        }
    }


}
