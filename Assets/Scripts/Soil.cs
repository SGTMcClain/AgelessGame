﻿using UnityEngine;
using System.Collections;

public class Soil : MonoBehaviour {

	public GameObject player;
	public GameObject m_Vine;
	public GameObject m_Tree;
//	public GameObject minorsoil;
	private PlayerInventory_JG playerInventory; 



	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag("Player");
		m_Vine = GameObject.FindGameObjectWithTag("Vine");
		m_Tree = GameObject.FindGameObjectWithTag("Tree");
		playerInventory = player.GetComponent<PlayerInventory_JG>();

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
		Debug.Log("Collider is: " + other.gameObject.CompareTag("Player"));
		Debug.Log("The Player has seed: " + playerInventory.VineSeed);
		Debug.Log("The Player has seed: " + playerInventory.TreeSeed);

		if (other.gameObject.CompareTag("Player") &&  playerInventory.VineSeed)
		{
			if (Input.GetKeyDown (KeyCode.G)) { 
				
				if (playerInventory.VineSeed)
				{
					m_Vine.SetActive(true);
					Debug.Log("Vine Seed Planted");
				}
			}
		}
		else
		{
			Debug.Log("You don't have the Vine Seed");
		}

		if (other.gameObject.CompareTag("Player") &&  playerInventory.TreeSeed)
		{
			if (Input.GetKeyDown (KeyCode.H)) { 
				
				if (playerInventory.TreeSeed)
				{
					m_Tree.SetActive(true);
					Debug.Log("Tree Seed Planted");
				}
			}
		}
		else
		{
			Debug.Log("You don't have the Tree Seed");
		}


	}


	
}
