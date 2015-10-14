using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson 
{
	[RequireComponent(typeof (ThirdPersonCharacter))]
	[RequireComponent(typeof(Animator))]
	public class PunchButton_JG: MonoBehaviour {
		//private bool m_Punch

		private Animator punch;
		private Collider hand1;
		private Collider hand2;
		public GameObject child1;
		public GameObject child2;
	
	
		// Use this for initialization

		void Start () {
			punch = GetComponent<Animator>();
		
		}
		
		// Update is called once per frame
		void Update () {

			if (Input.GetKeyDown (KeyCode.F)) {
		//Joel: If F is preessed the Animator "Punch" State Boolean is set to true
				punch.SetBool ("Punch", true);
			}
			else {
				punch.SetBool ("Punch", false);
			
			}

//Joel: This checks to see if the "Punch" State is active
//If this state is active it will activate the Colliders on the hands of our models
//Once the state turns off the colliders turn off
			
			AnimatorStateInfo stateInfo = punch.GetCurrentAnimatorStateInfo (0);
			if (punch.GetCurrentAnimatorStateInfo(0).IsName("Punch")) {
				child1.gameObject.SetActive (true);
				child2.gameObject.SetActive (true);  
			} else {
				child1.gameObject.SetActive (false);
				child2.gameObject.SetActive (false);

			}
		}


}
}

