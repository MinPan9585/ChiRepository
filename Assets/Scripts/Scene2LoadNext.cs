using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2LoadNext : MonoBehaviour
{
    public void Scene2LoadNextLevel()
    {
        SceneManager.LoadScene("Scene3");
    }
}
