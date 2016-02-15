using UnityEngine;
using System.Collections;

public class TreeOn : MonoBehaviour
{

    public bool VineSwitch;
    public bool TreeSwitch;
    public GameObject Tree;
    public GameObject Vine;

    void Awake()
    {
        Tree = GameObject.FindGameObjectWithTag("Tree");
        Vine = GameObject.FindGameObjectWithTag("Vine");

    }


    void Plant ()
    {
        if (VineSwitch == true)
            Vine.SetActive(true);
        else if (VineSwitch == false)
    
        if (TreeSwitch == true)
            Tree.SetActive(true);
        else if (TreeSwitch == false)
            Tree.SetActive(false);
    }
}