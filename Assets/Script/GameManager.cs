using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Sprite[] CoordiSpriteList;
    public string[] CoordiNameList;
    public int[] CoordiGoldList;
    public int[] CoordiDiaList;
    public int[] NumGoldList;
    public int[] ClickGoldList;

    public GameObject imageRestart;
    public Vector3[] PointList;
    // Start is called before the first frame update
    void Start()
    {
        if(imageRestart != null)
            imageRestart.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {

    }


}

