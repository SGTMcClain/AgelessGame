using UnityEngine;
using System.Collections;

public class EndTrigger2 : MonoBehaviour {
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag("Player"))

		{
			Application.LoadLevel(0);
		}

	}
}