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
	//	public GameObject m_wall;
	//	public GameObject m_edge;
		public Rigidbody rElder;
		public ThirdPersonCharacter grounded; 
		//public ThirdPersonCharacter rigid; 
		//Rigidbody m_Rigidbody;
	//	bool horizaontalEnable = true;
		//float horizontalMove;
	//	float moveSpeed = 0.1f;
		// Use this for initialization

		//float xPos;
	

		void Start () {
			m_climb = GetComponent<Animator>();
			bool grounded = GetComponent<ThirdPersonCharacter>();
			//bool rigid = GetComponent<ThirdPersonCharacter>();
			//m_wall = GameObject.FindWithTag ("Wall");
		//	m_Rigidbody = GetComponent<Rigidbody>();
		}
		
		// Update is called once per frame
		void Update () {
			//xPos = transform.position.x;
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

			//horizontalMove = Input.GetAxis ("Horizontal") * moveSpeed;
				}

		void OnTriggerStay(Collider target)


		{
			if(target.tag == "Wall")

			{

				rElder.isKinematic = true;

				grounded.m_IsGrounded = true;
		//		m_climb.SetBool ("OnWall", true);
				m_climb.SetBool ("IClimb", true);
				GetComponent<ThirdPersonUserControl> ().enabled = false;

				//transform.position += new Vector3 (horizontalMove,0);
				//horizontalMove = 0;

				//move.magnitude == 0f && !moveLocked;
				//m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
				//var pos = transform.position;
				//pos.x =  Mathf.Clamp(transform.position.x, 1, -1);
				//transform.position = pos;
			//	transform.position = new Vector3 (xPos, transform.position.x, 0);			
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

		void OnTriggerEnter(Collider target){
			if (target.tag == "Edge") {
				print ("EClimb enter triggered");
				m_climb.SetBool ("EClimb", true);
				m_climb.SetBool ("WClimb", false);
				m_climb.SetBool ("IClimb", false);

			}
		}



		void OnTriggerExit(Collider target)


		{
			if(target.tag == "Wall")

			{

				rElder.isKinematic = false;	
				m_climb.SetBool ("IClimb", false);
				m_climb.SetBool ("WClimb", false);
				GetComponent<ThirdPersonUserControl> ().enabled = true;

			}



			if (target.tag == "Edge")

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
