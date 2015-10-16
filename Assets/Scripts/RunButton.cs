using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson 
{
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
				// David - sets animation speed set in inspecter. tweak speed of speed boost in inspector
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
