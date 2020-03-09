using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    public GameObject winText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0f;
        winText.SetActive(true);
    }
}
