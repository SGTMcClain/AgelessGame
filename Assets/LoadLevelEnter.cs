using UnityEngine;
using System.Collections;

public class LoadLevelEnter : MonoBehaviour {

	
		void OnTriggerStay(Collider target)
		{
			if(target.tag == "Player")
			{
			Application.LoadLevel(1);
			}
		}



	}
