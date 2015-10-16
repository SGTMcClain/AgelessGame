using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson 
{
	[RequireComponent(typeof (ThirdPersonCharacter))]
	[RequireComponent(typeof(Animator))]
	public class Stun : MonoBehaviour {

		Animator stunAnimator;
	
	// Use this for initialization
	void Start () {
			stunAnimator = GetComponent<Animator> ();


		}
	
	

		// Update is called once per frame
	void Update () {

			//else 
			//{
			// don't use that while airborne
			//stunAnimator.speed = 1;
			//}
		}
	
		void OnCollisionStay(Collision other)
		{       
			//If the one colliding have the tag Cube it
			//will get destroyed
			
			if(other.gameObject.tag =="Cube")
			{
				stunAnimator.speed = 0;

			}
			
			}
	}

}