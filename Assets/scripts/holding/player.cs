using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Animator animator;
    public prop_chair prop_Chair;
    // Start is called before the first frame update
    void Start()
    {
        animator.Play("wait");
    }

    // Update is called once per frame
    void Update()
    {
        
        if(prop_Chair.sat == false){
            if(Input.GetKey(KeyCode.W))
        {
           // animator.enabled = true;
            animator.Play("walk");
            
        }else if (Input.GetKeyUp(KeyCode.W))
        {
            //animator.enabled = false;
            animator.Play("wait");
        }

         if(Input.GetKeyDown(KeyCode.S))
        {
           // animator.enabled = true;
            animator.Play("back");
        }else if (Input.GetKeyUp(KeyCode.S))
        {
            //animator.enabled = false;
            animator.Play("wait");
        }

         if(Input.GetKeyDown(KeyCode.A))
        {
           // animator.enabled = true;
            animator.SetBool("n", true);
        }else if (Input.GetKeyUp(KeyCode.A))
        {
            //animator.enabled = false;
            animator.Play("wait");
        }

         if(Input.GetKeyDown(KeyCode.D))
        {
           // animator.enabled = true;
            animator.Play("left");
        }else if (Input.GetKeyUp(KeyCode.W))
        {
            //animator.enabled = false;
            animator.Play("wait");
        }
        }
        
    }
}
