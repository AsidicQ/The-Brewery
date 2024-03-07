using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public GameObject player;
    public GameObject mainMenuUI;

    public Camera mainMenuCamera;
    public Camera playerCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainMenuCamera.enabled = true;
        playerCamera.enabled = false;
        player.SetActive(false);
    }

    public void StartGame()
    {
        mainMenuCamera.enabled = false;
        playerCamera.enabled = true;
        player.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void Tutorial()
    {
        //Start Tutorial
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
