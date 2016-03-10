using UnityEngine;
using System.Collections;

public class DrawGizmo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public bool _bIsSelected = true;

    void OnDrawGizmos()
    {
        if (_bIsSelected)
            OnDrawGizmosSelected();
    }


    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 0.1f);  //center sphere
        if (transform.GetComponent<Renderer>() != null)
            Gizmos.DrawWireCube(transform.position, transform.GetComponent<Renderer>().bounds.size);
    }
}
