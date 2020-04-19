using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    public GameObject credits;
    public GameObject mainMenu;
    public void StartGame()
    {  
        SceneManager.LoadScene("Tutorial");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
    }

    public void Return()
    {
        mainMenu.SetActive(true);
        credits.SetActive(false);
    }
}
