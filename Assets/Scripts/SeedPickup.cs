using UnityEngine;
using System.Collections;

public class SeedPickup : MonoBehaviour {

    public AudioClip seedGrab;  //AudioClip to play when the seed is grabbed
    private GameObject player;  //Reference to the player
    private PlayerInventory playerInventory; //Reference to the players inventory
   	
	void Awake () {

        player = GameObject.FindGameObjectWithTag("Player");
        //playerInventory = player.GetComponent<PlayerInventory>();
	
	}

    void OnTriggerEnter(Collider other)
    {
        // If the colliding gameobject is the player...
        if (other.gameObject.CompareTag("Player"))
        {
            // ... play the clip at the position of the key...
            //AudioSource.PlayClipAtPoint(seedGrab, transform.position);

            // ... the player has a key ...
            playerInventory.hasSeed = true;  
         
            // ... and destroy this gameobject.
            Destroy(gameObject);

            Debug.Log("Seed Touched");
        }
    }
}
