using UnityEngine;
using System.Collections;

public class RetryScript : MonoBehaviour {
    public int nextLevelInBuildSettings;
	//Retry Level using...
    public void RetryLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void NextLevel()
    {
        if (nextLevelInBuildSettings > 0)
        {
            Application.LoadLevel(nextLevelInBuildSettings);
        }
     
        else
        {
            Application.LoadLevel(Application.loadedLevel);
            
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
