using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour {

    private Canvas menuCanvas;
    private Canvas statsCanvas;

	// Use this for initialization
	void Start () {
        menuCanvas = GameObject.Find("MenuCanvas").GetComponent<Canvas>();
        statsCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void exitApplication()
    {
        Application.Quit();
    }

    public void continueGame()
    {
        menuCanvas.enabled = false;
        statsCanvas.enabled = true;
    }

    public void updateCanvases(bool menuOpen)
    {
        if(menuOpen)
        {
            menuCanvas.enabled = true;
            statsCanvas.enabled = false;
        }
        else
        {
            menuCanvas.enabled = false;
            statsCanvas.enabled = true;
        }
    }
}