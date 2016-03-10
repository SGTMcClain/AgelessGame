using UnityEngine;
using System.Collections;

public class ButtonPrompt : MonoBehaviour {


    public Canvas m_buttonUI;
    
   

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter(Collider otherPrompt)
    {

        if (otherPrompt.gameObject.tag =="Player")
        {
            
            m_buttonUI.enabled = true;

        }


    }


    void OnTriggerExit (Collider otherPrompt)
    {
        m_buttonUI.enabled = false;
    }

}



