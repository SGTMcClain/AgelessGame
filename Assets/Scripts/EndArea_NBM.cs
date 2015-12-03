using UnityEngine;
using System.Collections;

public class EndArea_NBM : MonoBehaviour {

    public GameObject player;
    private Animator anim;
    public GameObject endLevelPanel;
    private PlayerInventory playerInventory; 
    
    // Use this for initialization
	void Start () {

        anim = endLevelPanel.GetComponent<Animator>();
        anim.enabled = false;
        player = GameObject.FindGameObjectWithTag("Player");
        playerInventory = player.GetComponent<PlayerInventory>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter (Collider other)
    {
        Debug.Log("Collider is: " + other.gameObject.CompareTag("Player"));
        //Debug.Log("The Player has seed: " + playerInventory.hasSeed);

        if (other.gameObject.CompareTag("Player") &&  playerInventory.hasSeed)
        {
            Debug.Log("Touched End Space");
            PauseGameEnd();
        }
        else
        {
            Debug.Log("You don't have the seed");
        }
    }

    public void PauseGameEnd()
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




