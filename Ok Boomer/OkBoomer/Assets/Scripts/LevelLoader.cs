using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public GameObject credits;
    public GameObject mainMenu;
    public Animator transition;
    public string nextLevel;
    public void StartGame()
    {
        StartCoroutine(LoadLevel("Tutorial"));
        //SceneManager.LoadScene("Tutorial");
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

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.tag == "Player")
        {
            StartCoroutine(LoadLevel(nextLevel));
            //Time.timeScale = 0f;
        }
    }
    IEnumerator LoadLevel(string levelString)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene($"{levelString}");
    }
}
