using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public float GameTime = 0;
    public int iScore;
    public TextMeshProUGUI Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        GameTime += Time.deltaTime * 5.0f;
        iScore = (int)GameTime;
        Score.text = iScore.ToString();
    }
    
}
