﻿using UnityEngine;
using System.Collections;

public class EndTrigger1 : MonoBehaviour {
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag("Player"))

		{
			Application.LoadLevel(3);
		}

	}
}