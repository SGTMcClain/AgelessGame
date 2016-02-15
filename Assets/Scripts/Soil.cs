using UnityEngine;
using System.Collections;

public class Soil : MonoBehaviour {

	public GameObject player;
	private GameObject m_Vine;
	private GameObject m_Tree;

    private PlayerInventory_JG playerInventory;
//  private TreeOn PlantEnable;
    public bool disableTree;
    public bool disableVine;

    // Use this for initialization
    void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
        m_Vine = GameObject.FindGameObjectWithTag("Vine");
		m_Tree = GameObject.FindGameObjectWithTag("Tree");
		playerInventory = player.GetComponent<PlayerInventory_JG>();
    //    PlantEnable = GetComponent<TreeOn>();
     //   PlantEnable = GetComponent<TreeOn>();
    }
	
	// Update is called once per frame
/*	void Update () {
		if (Input.GetKeyDown (KeyCode.G)) { 
		
			if (playerInventory.VineSeed)
			{
				m_VineSeed.enabled = !m_VineSeed.enabled;
				Debug.Log("Vine Seed Planted");
			}
		}
	
} */	

	void OnTriggerEnter (Collider other)
	{
	//	Debug.Log("Collider is: " + other.gameObject.CompareTag("Player"));
	//	Debug.Log("The Player has seed: " + playerInventory.VineSeed);
	//	Debug.Log("The Player has seed: " + playerInventory.TreeSeed);

		if (Input.GetKeyDown(KeyCode.G) && other.gameObject.CompareTag("Player") &&  playerInventory.TreeSeed)
		{
				
                EnableTree();
				
			
		}
		else
		{
			Debug.Log("You don't have the Tree Seed");
		}

		if (Input.GetKeyDown(KeyCode.H) && other.gameObject.CompareTag("Player") &&  playerInventory.VineSeed)
		{

             EnableVine();
		}
		else
		{
			Debug.Log("You don't have the Vine Seed");
		}


	}

    void EnableTree()
    {



        //makes sure the code will not execute unless the correct plants are either enabled or disabled.
        if (disableTree == false && disableVine == true)
        {

            m_Tree.SetActive(true); //Joel - sets tree to active, works the same for baby and adult in EnableBaby() and EnableOld() etc.

            // Joel - disables Vine.
            m_Vine.SetActive(false);

        }


    }

    void EnableVine()
    {



        //makes sure the code will not execute unless the correct plants are either enabled or disabled.
        if (disableTree == true && disableVine == false)
        {

            m_Vine.SetActive(true); //Joel - sets tree to active, works the same for baby and adult in EnableBaby() and EnableOld() etc.

            // Joel - diables Tree.
            m_Tree.SetActive(false);

        }


    }


}
