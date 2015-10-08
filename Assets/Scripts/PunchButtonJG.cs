using UnityEngine;
using System.Collections;

public class PunchButtonJG : MonoBehaviour
{
    public Collider myCollider1;
    public Collider myCollider2;
    private Animator myAnimator;


  
  void Start()
    {
        myAnimator = GetComponent <Animator>();
        myCollider1 = GetComponent<Collider>();
        myCollider2 = GetComponent<Collider>();
    }


     void Update()
    {

        if (Input.GetKeyDown(KeyCode.V) && !animation.IsPlaying(punchAnimation))
        {
            //turn on renderers and start playing the animation
            myCollider1.enabled = true;
            myCollider2.enabled = true;


            //play the animation
            GetComponent<Animation>().Play("punch");

        else
        {
            //ensure animation stops
            animation.Stop(punchAnimation);

                //disable renderers
                myCollider1.enabled = false;
                myCollider2.enabled = false;
            }

    }
    





}