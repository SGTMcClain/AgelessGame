using UnityEngine;
using System.Collections;

public class LockRotation : MonoBehaviour
{
    Quaternion rotation;
   
    public
    // Use this for initialization
    void Start()
    {
        
        rotation = transform.rotation;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.rotation = rotation;
       
    }

}