using UnityEngine;
using System.Collections;

public class PlayerInventory_JG : MonoBehaviour {

	public bool VineSeed;
	public bool TreeSeed;

	public int Water = 10;
	//Display Water Variable

	public void TakeAway (int amount)
	{
		// Decrement the player's water.
		Water-= 1;
	}
	public void Add (int amount)
	{
		// Add to the player's water.
		Water+= 1;
	}

}
