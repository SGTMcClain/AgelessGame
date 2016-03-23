using UnityEngine;
using System.Collections;

public class SummonBall : MonoBehaviour {
    public GameObject magicBall;
    public GameObject spawnPoint;
   
    bool ballActive;
	// Use this for initialization
	void Start () {
        magicBall.transform.localPosition = spawnPoint.transform.position;
        ballActive = false;
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if (ballActive ==false && Input.GetKeyDown(KeyCode.E))
        {
           magicBall.transform.localPosition = spawnPoint.transform.position;
            magicBall.SetActive(true);
            
            ballActive = true;
        }

        else if (ballActive ==true && Input.GetKeyDown(KeyCode.E))

        {

            magicBall.SetActive(false);

         
            ballActive = false;
        }
	}


}
