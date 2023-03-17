using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public float GameTime = 0;
    public int iScore;
    public Text Score;
    Text a;

    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        GameTime += Time.deltaTime * 5.0f;
        iScore = (int)GameTime;
        a.text = Score.ToString();
        String.Format("{0:0000}",a);
    }
}
