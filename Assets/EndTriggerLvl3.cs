using UnityEngine;
using System.Collections;

public class EndTriggerLvl3 : MonoBehaviour {
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag("Player"))

		{
			Application.LoadLevel(4);
		}

	}
}