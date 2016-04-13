using UnityEngine;
using System.Collections;

public class Soil : MonoBehaviour {

	public GameObject player;
	public GameObject m_Vine;
	public GameObject m_Tree;
    public GameObject m_TreeSeed;
    public GameObject m_VineSeed;
	public WaterManager_JG w_meter;
    public PlayerInventory_JG playerInventory;

	public GameObject GUI_VineSeed;
	public GameObject GUI_TreeSeed;





//  private TreeOn PlantEnable;
//    public bool disableTree;
  //  public bool disableVine;

    // Use this for initialization
    void Start () {
		player = player.gameObject;
        m_Vine = m_Vine.gameObject;
		m_Tree = m_Tree.gameObject;
        m_TreeSeed = m_TreeSeed.gameObject;
        m_VineSeed = m_VineSeed.gameObject;
        playerInventory = player.GetComponent<PlayerInventory_JG>();
		//w_meter = GetComponent<WaterManager_JG>();

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

	void OnTriggerStay ()
	{
	
		//IF WE USE ONTRIGGERSTAY WE CANNOT PRINT OUT A MESSAGE TO THE CONSOLE OTHERWISE IT CAUSES A MEMORY LEAK
	//	Debug.Log("Collider is: " + player.gameObject);
	//	Debug.Log("The Player has seed: " + playerInventory.VineSeed);
	//	Debug.Log("The Player has tree seed: " + playerInventory.TreeSeed);
       
        if (playerInventory.TreeSeed == true)
		{
			if (Input.GetKeyDown(KeyCode.H))
            {
				if (w_meter.water >= 1f)
                {
				    m_Vine.SetActive(false);
                    m_Tree.SetActive(true);
                    m_TreeSeed.SetActive(true);
                    playerInventory.TreeSeed = false;
					w_meter.water -= 1f;
					playerInventory.useTreeSeed ();
				}
                else
                {
                    Debug.Log("You don't have enough Water");
                }

            }

        }
		else
		{
			//Debug.Log("You don't have the Tree Seed");
		}

        if (playerInventory.VineSeed == true)
        {
			if (Input.GetKeyDown(KeyCode.G ))
            {
				if (w_meter.water >= 1f)
				{
                
					m_Tree.SetActive(false);
                	m_Vine.SetActive(true);
                	m_VineSeed.SetActive(true);
                	playerInventory.VineSeed = false;
					w_meter.water -= 1f;
					playerInventory.useVineSeed ();
				
				}
                else
                {
                    Debug.Log("You don't have enough Water");
                }

            }

        }
        else
		{
			//Debug.Log("You don't have the Vine Seed");
		}


	}

    void EnableTree()
    {



        //makes sure the code will not execute unless the correct plants are either enabled or disabled.
        if (m_Tree == false)
        {

            m_Tree.SetActive(true); //Joel - sets tree to active, works the same for baby and adult in EnableBaby() and EnableOld() etc.


        }


    }

    void EnableVine()
    {



        //makes sure the code will not execute unless the correct plants are either enabled or disabled.
        if (Input.GetKeyDown(KeyCode.H))
        {

            m_Vine.SetActive(true); //Joel - sets tree to active, works the same for baby and adult in EnableBaby() and EnableOld() etc.

        }


    }


}
