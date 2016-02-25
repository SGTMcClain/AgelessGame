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
   public PlayerInventory_JG playerInventory;
   public GameObject player;
    public CharacterSwitch c_switch;

    Vector3 targetPos;
    // David - gets the intial position and loads the models/gameobjects at start that was set in inspecter
    void Start()
    {
        targetPos = transform.position;
        playerInventory = player.GetComponent<PlayerInventory_JG>();
        player = player.gameObject;
        switchBaby = switchBaby.gameObject;
        switchTeen = switchTeen.gameObject;
        switchOld = switchOld.gameObject;
        c_switch = player.GetComponent<CharacterSwitch>();
  
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
    // Joel - Each of the if statements below now checks if the forms are active in the scene heiarchy
    // joel- Readjusted this section of code so the script now switches between form if they are active
    // Joel-  Implementing water broke the script and would not allow for a complete switch, the camera would remain locked on certain forms 

    void Update()
    {

        //David - switch to baby
      
        /* if (Input.GetKeyDown(KeyCode.Alpha1) )
            {*/
        if (switchBaby.activeInHierarchy/*c_switch.disableTeen == false || c_switch.disableOld == false && c_switch.disableBaby == true*/ )
              {
                target = switchBaby;
                }
            //}
        //David - switch to teen

        /*   if (Input.GetKeyDown(KeyCode.Alpha2))

               {*/
            if (switchTeen.activeInHierarchy/*c_switch.disableBaby == false || c_switch.disableOld == false && c_switch.disableTeen == true */)
            {
                target = switchTeen;
            }
           // }
        
        //David - switch to adult
       
          /*  if (Input.GetKeyDown(KeyCode.Alpha3) )
            {*/
            if (switchOld.activeInHierarchy/*c_switch.disableTeen == false || c_switch.disableBaby == false && c_switch.disableOld == true*/ )
            {
                target = switchOld;
            }
            
            //}

       }
}