using UnityEngine;
using System.Collections;

public class SummonBall : MonoBehaviour {
    public GameObject magicBall;
    public GameObject spawnPoint;
   
    bool ballActive;
	// Use this for initialization
	void Start () {
        //  magicBall.transform.localPosition = spawnPoint.transform.position;
        // ballActive = false;
        magicBall.transform.position = spawnPoint.transform.localPosition;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (ballActive ==false && Input.GetKeyDown(KeyCode.E))
        {
          
            magicBall.SetActive(true);
            magicBall.transform.position = spawnPoint.transform.position;
            ballActive = true;
        }

        else if (ballActive ==true && Input.GetKeyDown(KeyCode.E))

        {

            magicBall.SetActive(false);

         
            ballActive = false;
        }
	}


}
