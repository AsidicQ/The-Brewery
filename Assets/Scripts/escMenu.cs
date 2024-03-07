using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escMenu : MonoBehaviour
{
    public GameObject escMenuUI;
    public GameObject player;
    public KeyCode escapeKey;
    bool isPaused;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        escMenuUI.SetActive(false);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(escapeKey))
        {
            escMenuUI.SetActive(true);
            isPaused = true;
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Input.GetKey(escapeKey) && isPaused)
        {
            escMenuUI.SetActive(false);
            isPaused = false;
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void ResumeGame()
    {
        escMenuUI.SetActive(false);
        isPaused = false;
        rb.constraints = RigidbodyConstraints.None;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void MainMenu()
    {
        escMenuUI.SetActive(false);
        isPaused = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        player.SetActive(false);
    }


}
