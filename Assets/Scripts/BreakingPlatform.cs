using UnityEngine;
using System.Collections;

public class BreakingPlatform : MonoBehaviour
{
    // platorm breaks when Teen and elderly walk onto it.

   //Instructions: Create an Empty Object add a trigger collider. Name the trigger to anything you wish. Make the platform you want to disappear when stepped ona child of the Empty Object. 

    public GameObject modelTeen;
    public GameObject modelElderly;
    public GameObject mPlatform;  //set the platform you want to disappear in inspector.
    






    void Start()

    {
        
    }

    void Update()
    {



     


    }





    //breaks the platform if Teen or Elderly
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == modelTeen.name || other.gameObject.name == modelElderly.name)
        {




            StartCoroutine(waitToBreak());






        }
    }

    //reforms the platform after some time

        void OnTriggerExit(Collider other) { 


        {
            StartCoroutine(waitToReform());
        }
    }
   




    


    IEnumerator waitToBreak()
    {

        yield return new WaitForSeconds(3);

        mPlatform.gameObject.SetActive(false);
        

        

        


    }


    IEnumerator waitToReform()

    {
        yield return new WaitForSeconds(5);
        mPlatform.gameObject.SetActive(true);
        
    }


}