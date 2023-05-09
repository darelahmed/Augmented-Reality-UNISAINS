using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    [SerializeField] private GameObject quitPanel;

    public void QuitGame()
    {
        quitPanel.SetActive(true);
    }

    public void Yes()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }

    public void No()
    {
        quitPanel.SetActive(false);
    }
}
