using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson 
{
//	[RequireComponent(typeof (ThirdPersonCharacter))]
//	[RequireComponent(typeof(Animator))]
	public class WallClimb_JG: MonoBehaviour {
		//private bool m_Punch

		private Animator m_climb;
		//private Collider hand1;
		//private Collider hand2;
		//public GameObject child1;
		//public GameObject child2;
		public GameObject modelElder;
		public GameObject m_wall;
		public GameObject m_edge;
		public Rigidbody rElder;
		public ThirdPersonCharacter grounded; 

	
		// Use this for initialization

		void Start () {
			m_climb = GetComponent<Animator>();
			bool grounded = GetComponent<ThirdPersonCharacter>();
		
		}
		
		// Update is called once per frame
		void Update () {

/*			if (Input.GetKeyDown (KeyCode.F)) {
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
*/	


				}

		void OnTriggerStay(Collider otherWall)


		{
			if (otherWall.gameObject.name == m_wall.name)

			{

				rElder.isKinematic = true;

				grounded.m_IsGrounded = true;
		//		m_climb.SetBool ("OnWall", true);
				m_climb.SetBool ("IClimb", true);
			
			
				if (Input.GetKey (KeyCode.W)) {
					//m_climb.SetBool ("IClimb", false);
					m_climb.SetBool ("WClimb", true);
					modelElder.transform.Translate (0, Time.deltaTime * 3, 0, Camera.main.transform);

				
				} 

				else 
				
				{
					m_climb.SetBool ("WClimb", false);
				//	m_climb.SetBool ("IClimb", true);
				}

				if (Input.GetKey(KeyCode.S))
				{
					//m_climb.SetBool ("IClimb"	, false);
					m_climb.SetBool ("WClimb", true);
					modelElder.transform.Translate(0, Time.deltaTime * -3, 0, Camera.main.transform);

				}

				/*if (otherWall.gameObject.name == m_edge.name) {
					print ("EClimb enter triggered");
					m_climb.SetBool ("EClimb", true);
					m_climb.SetBool ("WClimb", false);
					m_climb.SetBool ("IClimb", false);

				}*/



			}
		}

		void OnTriggerEnter(Collider otherWall){
			if (otherWall.gameObject.name == m_edge.name) {
				print ("EClimb enter triggered");
				m_climb.SetBool ("EClimb", true);
				m_climb.SetBool ("WClimb", false);
				m_climb.SetBool ("IClimb", false);

			}
		}



		void OnTriggerExit(Collider otherWall)


		{
			if (otherWall.gameObject.name == m_wall.name)

			{

				rElder.isKinematic = false;	
				m_climb.SetBool ("IClimb", false);
				m_climb.SetBool ("WClimb", false);

			}



			if (otherWall.gameObject.name == m_edge.name)

			{
				print ("EClimb exit triggered");
				rElder.isKinematic = false;	
				m_climb.SetBool ("IClimb", false);
				m_climb.SetBool ("WClimb", false);
				m_climb.SetBool ("EClimb", false);

			}



		}







}
}
