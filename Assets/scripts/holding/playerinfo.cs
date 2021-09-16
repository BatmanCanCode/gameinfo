using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerinfo : MonoBehaviour
{
    public float cash = 500;
    public float time;
    public job2 job;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time > 234)
        {
            job.random();
            time = 0;
        }
    }
}
