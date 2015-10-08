using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson 
{0
	[RequireComponent(typeof (ThirdPersonCharacter))]
	[RequireComponent(typeof(Animator))]
	public class RunButton: MonoBehaviour {

		public float m_RunSpeed;
		
		Animator runSpeed;
		
		// Use this for initialization
		void Start () {
			runSpeed = GetComponent<Animator>();

		}
		
		// Update is called once per frame
		void Update () {

			if (Input.GetKey (KeyCode.E)) {
				// David - sets animation speed to 2. Tweak speed of speed boost here
				runSpeed.speed = m_RunSpeed;
			}
			else 
			{
			// don't use that while airborne
			runSpeed.speed = runSpeed.speed;
			}
		}
	}
}
