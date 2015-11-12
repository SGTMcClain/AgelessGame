using UnityEngine;
using System.Collections;

public class LoadLevelEnterMainMenu : MonoBehaviour {

	
		void OnTriggerStay(Collider target)
		{
			if(target.tag == "Player")
			{
			Application.LoadLevel(0);
			}
		}



	}
