using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject imageRestart;
    // Start is called before the first frame update
    void Start()
    {
        imageRestart.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {

    }


}
