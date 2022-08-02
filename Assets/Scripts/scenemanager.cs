using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    public void onclickstart()
    {
        SceneManager.LoadScene(1);
    }
    public void restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;

    }
    public void quit()
    {
        Application.Quit();
    }
    public void resume()
    {
        Time.timeScale = 1;

    }
}
