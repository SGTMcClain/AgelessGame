using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            GetComponent<Animation>().Play("punch");
        }
    }
}




















