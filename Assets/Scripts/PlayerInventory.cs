using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {

	public static int TreeSeedCounter = 2;
	public static int VineSeedCounter = 2;
	public bool hasSeed;


	public void collectTreeSeed(){
		Debug.Log ("Collected a TreeSeed. Current TreeSeed = " + TreeSeedCounter);
		TreeSeedCounter++;
	}

	public void collectVineSeed(){
		Debug.Log ("Collected a VineSeed.  Current VineSeed = \" + VineSeedCounter);");
		VineSeedCounter++;
		
	}

	public void useTreeSeed(){
		Debug.Log ("Used a TreeSeed.  Current TreeSeed = " + TreeSeedCounter);
		TreeSeedCounter--;
	}

	public void useVineSeed(){
		Debug.Log ("Used a VineSeed.  Current VineSeed = " + VineSeedCounter);
		VineSeedCounter--;
	}
		
}
