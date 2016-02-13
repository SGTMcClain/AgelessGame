using UnityEngine;
using System.Collections;

public class SeedPickup_JG : MonoBehaviour {

    //public AudioClip seedGrab;  //AudioClip to play when the seed is grabbed
    private GameObject player;  //Reference to the player
	public GameObject m_VineSeed;  //Reference to the player
	public GameObject m_TreeSeed;
	private PlayerInventory_JG playerInventory; //Reference to the players inventory

	void Awake () {

        player = GameObject.FindGameObjectWithTag("Player");
		m_TreeSeed = GameObject.FindGameObjectWithTag("TreeSeed");
		m_VineSeed = GameObject.FindGameObjectWithTag("VineSeed");
		playerInventory = player.GetComponent<PlayerInventory_JG>();

		//playerInventory = player.GetComponent<PlayerInventory>();
	
	}

    void OnTriggerEnter(Collider other)
    {
      /*  // If the colliding gameobject is the player...
        if (other.gameObject.CompareTag("Beanstalk"))
        {
            // ... play the clip at the position of the key...
            //AudioSource.PlayClipAtPoint(seedGrab, transform.position);

            // ... the player has a key ...
            playerInventory.BeanstalkSeed = true; 
         
            // ... and destroy this gameobject.
            Destroy(gameObject);

            Debug.Log("Seed Touched");
        }
*/
		if (other.gameObject.CompareTag("VineSeed"))
		{
			// ... play the clip at the position of the key...
			//AudioSource.PlayClipAtPoint(seedGrab, transform.position);
			
			// ... the player has a key ...
			playerInventory.VineSeed = true; 
			
			// ... and destroy this gameobject.
			Destroy(other.gameObject);
			
			Debug.Log("Vine Seed Touched");
		}

		if (other.gameObject.CompareTag("TreeSeed"))
		{
			// ... play the clip at the position of the key...
			//AudioSource.PlayClipAtPoint(seedGrab, transform.position);
			
			// ... the player has a key ...
			playerInventory.TreeSeed = true; 
			
			// ... and destroy this gameobject.
			Destroy(other.gameObject);
			
			Debug.Log("Tree Seed Touched");
		}







    }





}
