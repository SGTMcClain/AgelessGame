using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public float interpVelocity; // David - variable for how fast the camera will lag behind
   // public float minDistance; // David - not used. Useful if we add camera controls.
   // public float followDistance; // David - not used. More useful for "behind the back." Left in here because can turn into camera lag when used with interpVelocity.
    public GameObject target; // David -the current target the camera is following
    public Vector3 offset;
   
    // David - must set the models we are using for each character for the camera to know what to switch to
   public GameObject switchBaby;     
   public GameObject switchTeen;
   public GameObject switchOld;
   


    Vector3 targetPos;
    // David - gets the intial position and loads the models/gameobjects at start that was set in inspecter
    void Start()
    {
        targetPos = transform.position;
        
        

    }
    // David - code for finding the target character and allowing the camera to follow
    void FixedUpdate()
    {
        if (target)
        {
            Vector3 posNoZ = transform.position;
            posNoZ.z = target.transform.position.z;
            Vector3 targetDirection = (target.transform.position - posNoZ);
            interpVelocity = targetDirection.magnitude * 90f; // David - how much the camera lags behind character
            targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, targetPos + offset, 0.25f);
        }
    }


   // David - switches the camera to lock on to the specific character with the buttons that match from Character Switch
    void Update()
    {

        
        //David - switch to baby
        if (Input.GetKeyDown(KeyCode.Alpha1))
       {
            target = switchBaby;
           
        }

        //David - switch to teen
        if (Input.GetKeyDown(KeyCode.Alpha2))
     {
            
            target = switchTeen;
            
        }

        //David - switch to adult
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            
            target = switchOld;
        }
    }
}