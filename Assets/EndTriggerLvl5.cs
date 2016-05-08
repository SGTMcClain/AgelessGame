using UnityEngine;
using System.Collections;

public class EndTriggerLvl5 : MonoBehaviour {
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag("Player"))

		{
			Application.LoadLevel(9);
		}

	}
}