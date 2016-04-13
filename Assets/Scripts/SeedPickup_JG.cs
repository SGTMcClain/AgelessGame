using UnityEngine;
using System.Collections;

public class SeedPickup_JG : MonoBehaviour {

    //public AudioClip seedGrab;  //AudioClip to play when the seed is grabbed
    public GameObject player;  //Reference to the player
	public GameObject m_VineSeed;
	public GameObject m_TreeSeed;
	public PlayerInventory_JG playerInventory; //Reference to the players inventory

	public GameObject GUI_VineSeed;
	public GameObject GUI_TreeSeed;

	void Awake () {
        player = player.gameObject;
		m_TreeSeed = m_TreeSeed.gameObject;
        m_VineSeed = m_VineSeed.gameObject;
        playerInventory = player.GetComponent<PlayerInventory_JG>();



	
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
	if (other.gameObject.CompareTag("Player") && m_VineSeed)
		{
			// ... play the clip at the position of the key...
			//AudioSource.PlayClipAtPoint(seedGrab, transform.position);
			
			// ... the player has a key ...
			playerInventory.VineSeed = true;
			playerInventory.collectVineSeed();

            // ... and destroy this gameobject.
            gameObject.SetActive(false);
			GUI_VineSeed.SetActive (true);

            Debug.Log("Vine Seed Touched");
		}

		if (other.gameObject.CompareTag("Player") && m_TreeSeed)
		{
			// ... play the clip at the position of the key...
			//AudioSource.PlayClipAtPoint(seedGrab, transform.position);
			
			// ... the player has a key ...
			playerInventory.TreeSeed = true;

            // ... and destroy this gameobject.
            gameObject.SetActive(false);
			GUI_TreeSeed.SetActive (true);

            Debug.Log("Tree Seed Touched");
		}







    }





}
