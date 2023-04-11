using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float JumpForce;
    [SerializeField]
    bool isGround = false;
    [SerializeField]
    bool isJump = false;
    [SerializeField]
    bool isSlide = false;
    Rigidbody2D RB;
    CircleCollider2D CC;
    [SerializeField]
    private float Speed;

    AudioSource AS;
    public AudioClip Jump;
    public AudioClip Die;
    public AudioClip Land;
    public AudioClip Coinsound;


    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        AS = GetComponent<AudioSource>();
        CC = GetComponent<CircleCollider2D>();
        AS.loop = false;
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isGround && !isSlide)
            {
                RB.AddForce(Vector2.up * JumpForce);
                isGround = false;
                isJump = true;
                AS.clip = Jump;
                AS.Play();
            }
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(isGround && !isJump)
            {
                CC.offset = new Vector2(0f, 0.3f);
                CC.radius = 0.3f;
                isSlide = true;
            }
        }

        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            CC.offset = new Vector2(0f, 0.4f);
            CC.radius = 0.4f;
            isSlide = false;
            
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            if(isGround == false)
            {
                isGround = true;
                isJump= false;
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
            GameManager gameManager = GameObject.FindObjectOfType<GameManager>();
            gameManager.imageRestart.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Coin"))
        {
            ScoreScript.Coin += 1;
            AS.clip = Coinsound;
            AS.Play();
        }
    }

}
