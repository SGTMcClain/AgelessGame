using UnityEngine;
using System.Collections;

public class LoadLevel
: MonoBehaviour {

	//Loads Next Level
    public void RetryLevel()
    {
		Application.LoadLevel(1);
    }
}
