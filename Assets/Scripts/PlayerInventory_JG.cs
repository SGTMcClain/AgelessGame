using UnityEngine;
using System.Collections;

public class PlayerInventory_JG : MonoBehaviour {

	public bool VineSeed;
	public bool TreeSeed;

	public float Water = 10f; 

	public void TakeAway (float amount)
	{
		// Decrement the player's water.
		Water-= 1;
	}
	public void Add (float amount)
	{
		// Add to the player's water.
		Water+= 1;
	}

}
