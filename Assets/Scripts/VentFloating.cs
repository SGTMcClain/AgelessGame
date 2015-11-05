using UnityEngine;
using System.Collections;

public class VentFloating : MonoBehaviour {


    public GameObject modelBaby;
  

    // Use this for initialization
    void Start () {
       
	}

    // Update is called once per frame
    void Update()
    {

        
    }



    void OnTriggerStay(Collider otherBaby)


    {
        if (otherBaby.gameObject.name == modelBaby.name)
                
        {

            otherBaby.attachedRigidbody.velocity = new Vector3(0, 5, 0);
            if (Input.GetKey(KeyCode.D))
            {
                
                otherBaby.transform.Translate(Time.deltaTime*3, 0, 0, Camera.main.transform);
            }

            if (Input.GetKey(KeyCode.A))
            {

                otherBaby.transform.Translate(Time.deltaTime * -3, 0, 0, Camera.main.transform);
            }

        }
              
           
            //Physics.gravity = new Vector3(0, -1.0F, 0);

        }
    }




  


   // void FloatingBaby()
   //{
   //   Physics.gravity = new Vector3(0, -1.0F, 0);
   //}



