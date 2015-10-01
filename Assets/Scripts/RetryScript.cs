using UnityEngine;
using System.Collections;

public class RetryScript : MonoBehaviour {

	//Retry Level using...
    public void RetryLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
