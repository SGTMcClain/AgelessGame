using UnityEngine;
using System.Collections;

public class BreakingPlatform : MonoBehaviour
{
    // platorm breaks when Teen and elderly walk onto it.
    
    public GameObject modelTeen;
    public GameObject modelElderly;


    void Start()
    {
        
    }


    void Update()
    {



    }
    void OnCollisionEnter(Collision other)
    {
        if  (other.gameObject.name == modelTeen.name || other.gameObject.name == modelElderly.name)
        {
           gameObject.SetActive(false);
        }
       
    }
}

    