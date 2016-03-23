using UnityEngine;
using System.Collections;
//water manager code
using UnityEngine.UI;

public class PlayerInventory_JG : MonoBehaviour {

	public bool VineSeed;
	public bool TreeSeed;
	public GameObject GUI_VineSeed;
	public GameObject GUI_TreeSeed;

	void Update() {
		if(TreeSeed == false)
			{
				GUI_TreeSeed.SetActive (false);
			}

		if(VineSeed == false)
		{
			GUI_VineSeed.SetActive (false);
		}
	}


	//Water Manager Code
/*
	public float Water = 10f;                         // How much health the player has left
	public float maxWater = 10f;
	public float minWater = 0f;
	public float addWaterAmt = 1f;
	public float takeWaterAmt = 1f;


	public int Water = 10;
	Display Water Variable

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


//Water Manager Code
	void Update(){
		UI_WaterMeter ();
		UI_WaterCheck ();

	}
	public void TakeAway (float amount)
	{
		// Decrement the player's water.
		Water-= takeWaterAmt;

	}
	public void Add (float amount)
	{
		// Add to the player's water.
		Water+= addWaterAmt;

	}
	public void UI_WaterMeter(){
		Image image = GetComponent<Image> ();
		image.fillAmount = Water / maxWater;
		Debug.Log ("current water is: " + image.fillAmount);

		//Test
		if(Input.GetButtonDown("WaterTestUP")){
			Water++;
		}

		if(Input.GetButtonDown("WaterTestDOWN")){
			Water--;
		}
			
	}

	public void UI_WaterCheck(){
		if (Water > maxWater){
			Water = maxWater;
		}
		if (Water < minWater){
			Water = minWater;
		}
	}

// Water manager Code

*/
}
