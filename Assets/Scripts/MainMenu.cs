﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public Canvas quitMenu;
    public Button startText;
    public Button quitText;


	// Use this for initialization
	void Start ()
    { 
        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        quitText = quitText.GetComponent<Button>();
        quitMenu.enabled = false;
        
    }
	
    public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        quitText.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        quitText.enabled = true;
    }

    public void StartLevel()
    {
        Application.LoadLevel(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
