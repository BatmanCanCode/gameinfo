using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class console : MonoBehaviour
{
    public string wait;
    public string one ;
    public string two ;
    public string three ;
    public string four ;
    public Text onet;
    public Text twot;
    public Text threer;
    public Text fourt;
    public string use;
    public job1 job;
    public job2 job2;
    public job3 job3;

    public buildings place;
    public InputField textin;
    void Start()
    {
        
        Debug.Log(job3.drone);
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if(Input.GetKeyUp(KeyCode.Return))
        {
            use = textin.text;
            if (textin.text == "$locatecode")
            {
                job.job();
            }
            
            if (use.Contains("$send"))
            {
               codecheck();
            }

            if (textin.text == "$check " + job3.drone)
            {
                Debug.Log("yep");
            }else
                if (textin.text == "$check " + job3.drone + " ")
            {
                Debug.Log("yep");
            }

            if (textin.text == "$connect" + " " + job3.drone)
            {
                job3.drone_connect = true;
                job3.drone2_connect = false;
            }else if (textin.text == "$connect" + " " + job3.drone + " ")
            {
                job3.drone_connect = true;
                job3.drone2_connect = false;
            }

             if (textin.text == "$drone.status")
             {
                if(job3.drone_connect == true){
                    wait = job3.drone_data;
                    consoleprint();
                }
            }
             if( textin.text == "$drone.setHome" +" " + place.warehouse)
             {
                 if(job3.drone_connect == true){
                {
                    print("hi");
                job3.right();
                }
             }else  if( textin.text == "$drone.setHome" +" " + place.warehouse +" ")
             {
                if(job3.drone_connect == true)
                {
                    print("hi");
                    job3.right();
                }else if(0==0)
                {
                    job3.wrong();
                }
                
             }else  if( textin.text.Contains("$drone.setHome"))
             {
                print("f");
                job3.wrong();
             }
            }
        }
    }
    public void codecheck()
    {
        if (textin.text == "$send " + job.id+  " "+ job.point)
        {
                job.jobstart();
        }else
            if(0 == 0)
            {
              Debug.Log("s");
            }
    }


    public void consoleprint()
    {
        
        four = three.ToString();
        three = two.ToString();
        two = one.ToString();
        one = wait.ToString();
        onet.text = one.ToString();
        twot.text = two.ToString();
        threer.text = three.ToString();
        fourt.text = four.ToString();
        
    }
    

}
