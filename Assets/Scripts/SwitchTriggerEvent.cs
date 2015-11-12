using UnityEngine;
using System.Collections;

public class SwitchTriggerEvent : MonoBehaviour {
    // Framework for a script that triggers an event when a character walks over a switch (or pressure plate). Switch has the functionally to be activate exclussively with a specific character. 
    // can be determine which character can active the trigger/switch in inspector.
    // Set the models and which character/s you want to activate the switch in inspector. A marked checkbox in inspector means the event will trigger with that character.
    public GameObject modelTeen;
    public GameObject modelElderly;
    public GameObject modelBaby;
    
    //Add gameobjects or tags for what you want to be affected by the trigger. Example would be a door object that opens when Teen walks over the switch.
    public GameObject eventDoor; //this is an example, change or add objects as needed
    
    public bool triggerOnBaby;
    public bool triggerOnTeen;
    public bool triggerOnOld;






    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Example
    void OnTriggerEnter(Collider other)
    {
        // Enter what you want the trigger to do bellow. OnTriggerStay may need to be used if there is another event/trigger once you leave the switch

        // Example code for a switch that activates with Teen: 
        if (other.gameObject.name == modelTeen.name && triggerOnTeen == true)

      {
            //Enter what you want the trigger to do here
            //example for door - set how you want to door to move/swing by changing the x, y, or z for Vector3
            eventDoor.transform.Translate(new Vector3(0.0f, 0.0f, 0.0f)); // or for swinging doors eventDoor.transform.Rotate(new Vector3(0.0f, 0.0f, 0.0f));

        }
    }

}
