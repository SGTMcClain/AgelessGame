using UnityEngine;
using System.Collections;

public class DestroyBallCrate : MonoBehaviour {

    public GameObject ball;

    

	// Use this for initialization
	void Start () {
        ball = this.gameObject;

      
    }
	
	// Update is called once per frame
	void Update ()
        
        
        
        
    {
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3))

         
            Destroy(ball);

     
    }
}

