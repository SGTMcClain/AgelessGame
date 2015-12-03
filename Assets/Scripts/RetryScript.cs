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
        
        
            Application.LoadLevel(nextLevelInBuildSettings);
        
     
    
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
