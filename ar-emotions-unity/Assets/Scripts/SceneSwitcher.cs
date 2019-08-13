using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private static bool easy = false;
    private static bool advanced = false;

    public void LoadEasy()
    {
        easy = true;
        advanced = false;
        SceneManager.LoadScene("easy");
    }

    public void LoadAdvanced()
    {
        easy = false;
        advanced = true;
        SceneManager.LoadScene("advanced");
    }

    public void LoadMenu()
	{
        SceneManager.LoadScene("menu");
	}

    public void Restart()
    {
        if (easy == true)
            SceneManager.LoadScene("easy");
        else
            SceneManager.LoadScene("advanced");
    }

    public void LoadFinished()
    {
        SceneManager.LoadScene("finished");
    }

    public void LoadReview()
    {
        if (easy == true)
            SceneManager.LoadScene("easy-review");
        else
            SceneManager.LoadScene("advanced-review");
    }
}
