using UnityEngine;
using System.Collections;

public class DestroyObject_JG : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		//DestroyObject (this.gameObject);
		if (other.tag == "Hands")
		{
			Destroy (gameObject);
		}
	}
}
