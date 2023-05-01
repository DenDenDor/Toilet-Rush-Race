using System.Collections;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScene : MonoBehaviour
{
    public void LoadScene(string name) => SceneManager.LoadScene(name);
    public void ReloadScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    public void OpenNextScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}
