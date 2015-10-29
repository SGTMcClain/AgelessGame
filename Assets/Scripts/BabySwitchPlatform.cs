using UnityEngine;
using System.Collections;




//[RequireComponent(typeof(CameraFollow))] <-------if we find out that we need to tie this script to the camera. Not needed for now.
//THis a Clone of David Hendricks Script

/* Summary - script for character switching in-game. Allows the selection of models in inspector for "baby," "teen," and "old." Important if model names are changed. 
The code swaps the character with a button press "1" for baby, "2" for Teen, and "3" for adult. 
The switch will swap out a character for another and place the new character at the current position of the old character.
Also disables the button for the current character. Without the disable code, pressing the button again will result in the character warping to the inactive character's last place when it was active.
The code also needs to be told what is the starting character for the level or scene in order for the script to know which models are disabled at start.

Note - Optimization can be made. For example, we can use tags instead of the setting the models in inspector. 
*/


public class BabySwitchPlatform : MonoBehaviour
{
    // David - sets the specific models for the script in inspector
    public GameObject baby;
    public GameObject teen;
    public GameObject old;
   // public GameObject startCharacter; // David - allows to designate a starting character for the level. Not used except for reference in inspector. May be useful for later. For example for random character look

    // David - check in inspector which characters are disabled at start of the level. * Important for the code to work properly * 
    public bool disableTeen; 
    public bool disableBaby;
    public bool disableOld;




    // David - at start looks for what gameObjects/models in inspector that we designate as "Baby" "Teen" "Old" passes them to the variable. 
    //StartingCharacter should be the starting character when the level begins. 

    void Start()
    {
        //startCharacter = startCharacter.gameObject; // David - not used for now
        baby = baby.gameObject;
        teen = teen.gameObject;
        old = old.gameObject;
       

    }

   
 

    // David - Takes the input of the key "1" "2" or "3" and enables the character for the key pressed

 



void OnTriggerEnter (Collider other)
		{
			if (other.tag == "Player")
			{
				EnableBaby();
			}
		}



    void EnableBaby()
    {
        

        if (disableTeen == false && disableOld == true && disableBaby == true)
        {
            baby.SetActive(true);

            teen.SetActive(false);
            old.SetActive(false);

            baby.transform.position = teen.transform.position;
            baby.transform.rotation = teen.transform.rotation;
        }


        if (disableTeen == true && disableOld == false && disableBaby == true)
        {
            baby.SetActive(true);

            teen.SetActive(false);
            old.SetActive(false);

            baby.transform.position = old.transform.position;
            baby.transform.rotation = old.transform.rotation;
        }

        disableTeen = true;
        disableOld = true;
        disableBaby = false;
    }

    
    

}

