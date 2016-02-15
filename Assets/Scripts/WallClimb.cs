using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class WallClimb : MonoBehaviour
{
    
    public GameObject modelElder;
    public Rigidbody rElder;

  public ThirdPersonCharacter grounded; 


    // Use this for initialization
    void Start()
    {
        bool grounded = GetComponent<ThirdPersonCharacter>();
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider otherElder)


    {
        if (otherElder.gameObject.name == modelElder.name)

        {

            rElder.isKinematic = true;
          
            grounded.m_IsGrounded = true;
         

            if (Input.GetKey(KeyCode.W))
            {

                otherElder.transform.Translate(0, Time.deltaTime * 3, 0, Camera.main.transform);
            }

            if (Input.GetKey(KeyCode.S))
            {

                otherElder.transform.Translate(0, Time.deltaTime * -3, 0, Camera.main.transform);
            }







        }
    }

    void OnTriggerExit(Collider otherElder)


    {
        if (otherElder.gameObject.name == modelElder.name)

        {

            rElder.isKinematic = false;
        }

    }
}
