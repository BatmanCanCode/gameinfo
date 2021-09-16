using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prop_chair : MonoBehaviour
{
    public bool seat = false;
    public GameObject player;
    public Animator animator;
    public GameObject seat_1;
    public GameObject seat_1_mark;

    public bool sat;
    void OnTriggerStay(Collider other)
     {
         Rigidbody h = player.GetComponent<Rigidbody>();
         if(!sat)
         {
          if (Input.GetKeyDown(KeyCode.E))
          {
            
            animator.Play("sat");
          }
         }
          
     } //transform.rotation.y = target.rotation.y;   1.164  0.581 -0.7182184
    
}


//key stop when sat