using UnityEngine;
using System.Collections;

public class Z_LockJG : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	//This script is used to lock the player character onto the z axis 
	//The root motions in the animations moved players out of the Z-axis
	//Originally we used colliders but they can cause issues when the models turn
	//Therefore we needed to code soemthing to keep the player in place
	//With the code below we do not need colliders to keep players on the Z-axis
	void Update () {
		// lock Z position from moving!
		var pos = transform.position;
		pos.z =  Mathf.Clamp(transform.position.z, 0, 0);
		transform.position = pos;
	}
}
