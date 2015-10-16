using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(CameraFollow))]
public class CharacterSwitch : MonoBehaviour
{

    public GameObject baby;
    public GameObject teen;
    public GameObject old;
  




    // Use this for initialization
    void Start()
    {
        baby = baby.gameObject;
        teen = teen.gameObject;
        old = old.gameObject;
        




    }




    // Update is called once per frame
    void Update()

    {
       

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            teen.SetActive(false);
           


            baby.SetActive(true);


            baby.transform.position = teen.transform.position;
            baby.transform.rotation = teen.transform.rotation;


        }


        





        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            baby.SetActive(false);
           

            teen.SetActive(true);
          
            teen.transform.position = baby.transform.position;
            teen.transform.rotation = baby.transform.rotation;


        }



    }
       
    }

