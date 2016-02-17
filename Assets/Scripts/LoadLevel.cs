using UnityEngine;
using System.Collections;

public class LoadLevel
: MonoBehaviour {


	//Loads Next Level
    public void RetryLevel()
    {
		Application.LoadLevel(Application.loadedLevel);
    }

	public void StartGame ()
	{
		Application.LoadLevel(1);
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void MainMenu()
	{
		Application.LoadLevel (0);
	}

	public void StageSelect()
	{
		Application.LoadLevel ("StageSelect");
	}

}
