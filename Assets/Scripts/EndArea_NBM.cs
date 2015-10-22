using UnityEngine;
using System.Collections;

public class EndArea_NBM : MonoBehaviour {

    public GameObject Player;
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            PauseGameEnd();
        }
    }

    public static void PauseGameEnd()
    {

        Time.timeScale = 0;

    }

    public static void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
