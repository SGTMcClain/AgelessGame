using UnityEngine;
using System.Collections;

public class EndArea_NBM : MonoBehaviour {

    public GameObject Player;
    private Animator anim;
    public GameObject endLevelPanel;
    
    // Use this for initialization
	void Start () {

        anim = endLevelPanel.GetComponent<Animator>();
        anim.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Touched End Space");
            EndLevelPauseGame();
        }
    }

    public void EndLevelPauseGame()
    {

        Time.timeScale = 0;
        anim.enabled = true;
        anim.Play("PauseMenuSlideIn");

    }

    public static void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
