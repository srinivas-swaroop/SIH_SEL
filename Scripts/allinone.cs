using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class allinone : MonoBehaviour
{
    public void load_alphabet()
    {
        SceneManager.LoadScene("Alphabets");
    }

     public void load_UIMENU()
    {
        SceneManager.LoadScene("UI_MENU");
    }

    public void load_UIMAIN()
    {
        SceneManager.LoadScene("UI_MAIN");
    }

    public void load_About()
    {
        SceneManager.LoadScene("About");
    }

    public void load_Design()
    {
        SceneManager.LoadScene("Design");
    }

    public void quit()
    {
        Application.Quit();
    }
}
