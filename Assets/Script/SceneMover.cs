using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneMover : MonoBehaviour
{
    void SceneMove(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
