using UnityEngine;
using System.Collections;

public class LockPositionandFollow : MonoBehaviour {


    public GameObject bounceCube;

    public
    // Use this for initialization
    void Start()
    {
        bounceCube.transform.position = transform.position;
      
    }

    // Update is called once per frame
    void LateUpdate()
    {

        bounceCube.transform.position = transform.position;
       
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            bounceCube.SetActive(true);


        }

        else
            bounceCube.SetActive(false);
    }
}