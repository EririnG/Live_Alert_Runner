using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float JumpForce;
    [SerializeField]
    bool isGround = false;
    Rigidbody2D RB;
    [SerializeField]
    private float Speed;

    AudioSource AS;
    public AudioClip Jump;
    public AudioClip Die;
    public AudioClip Land;


    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        AS = GetComponent<AudioSource>();
        AS.loop = false;
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isGround)
            {
                RB.AddForce(Vector2.up * JumpForce);
                isGround = false;
                AS.clip = Jump;
                AS.Play();
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            if(isGround == false)
            {
                isGround = true;
                AS.clip = Land;
                AS.Play();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
        }
    }

}
