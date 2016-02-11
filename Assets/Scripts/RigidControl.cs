using UnityEngine;
using System.Collections;

public class RigidControl : MonoBehaviour 
{
	public float accelConstant;
	private 
	void Update()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float jumpers = 0;
		if(Input.GetKeyDown (KeyCode.Space))
		{
			jumpers = 20.0f;
		}
		Vector3 movement = new Vector3 (moveHorizontal, jumpers);    

		GetComponent<Rigidbody>().AddForce (movement * accelConstant );		
	}



}