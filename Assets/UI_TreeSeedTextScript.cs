using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_TreeSeedTextScript : MonoBehaviour {

	public Text UI_TreeSeedText ;
	//public Text UI_VineSeedText ;

	//string treeSeedCount = PlayerInventory_JG.TreeSeedCounter.ToString();
	//string vineSeedCount = PlayerInventory_JG.VineSeedCounter.ToString();

	// Use this for initialization
	void Start () {
		UI_TreeSeedText = GetComponent<Text> ();
		//UI_VineSeedText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		TreeSeedText ();


	
	}

	void TreeSeedText(){
		UI_TreeSeedText.text = PlayerInventory_JG.TreeSeedCounter.ToString();
	}

	/*
	void VineSeedText(){
		UI_VineSeedText.text = PlayerInventory_JG.VineSeedCounter.ToString();
	}
	*/
}
