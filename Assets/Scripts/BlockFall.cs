using UnityEngine;
using System.Collections;

public class BlockFall : MonoBehaviour {


    public GameObject block;

    bool triggerActive;
	// Use this for initialization
	void Start () {
        triggerActive = true;
    }
	
	// Update is called once per frame
	void Update () {
	
	}



    void OnTriggerEnter(Collider box)

    {
        if (triggerActive == true)
        {
            StartCoroutine(waitToFall());
        }
    }

   // void OnTriggerExit(Collider box)
   // {
    //    block.transform.Translate(0, 5, 0);
    //}

    IEnumerator waitToFall()
    {

        yield return new WaitForSeconds(.04f); // this how long before platform breaks/disappears




        block.transform.Translate(0, -5, 0, Camera.main.transform);


        triggerActive = false;

    }

}
