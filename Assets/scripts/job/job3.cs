using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class job3 : MonoBehaviour
{
    public buildings place;
    public console console;
    public storeage store;
    public string drone;
    public int drone_1;
    public int drone_2;
    public int drone_3;
    public string drone_data;
    string drone_data_run; //timeleft
    public string drone_data_loc;
    public bool drone_connect;

    public string drone2;
    public int drone2_1;
    public int drone2_2;
    public int drone2_3;
    public bool drone2_connect;

    public int job_loc;
    public int job_loc_2;
    public int job_run;
    
    public float jobtime = 0;
    public float time;

    public float jobtimef = 0;
    public float timef;
    public bool activef = false;
    public bool active = false;
    

    public void startjob() // gens a IP to give to player to enter
    {
        drone_1 = Random.Range(100, 1000);
        drone_2 = Random.Range(100, 1000);
        drone_3 = Random.Range(100, 1000);
        drone = drone_1.ToString() + "," + drone_2.ToString() + "," + drone_3.ToString();
        job_loc = Random.Range(0, 101);
        job_loc_2 = Random.Range(0, 101);
        job_run = Random.Range(0, 51);
        drone_data_loc = job_loc + ","+job_loc_2;
        drone_data = "Run time " + job_run + ", Location " + job_loc+", "+job_loc_2;
    }// pplayer could have a team memebr at a park to see if anyone is using drones to get ips;

    private void Update() {
        if(active == true)
        {
            time += Time.deltaTime;
        }    
        if(activef == true){
            timef += Time.deltaTime;
        }

        if(time > jobtime)
        {
            
            
            store.drone += 1;
            done();
            time = 0;
            active = false;
            time = 0;
        }

        if(timef > jobtime)
        {
            activef = false;
            timef = 0;
            done();
        }
    }

    public void right()
    {
        if(job_run > 26)
        {
            jobtime = 250;
            active = true;
        }else
        if(job_run < 26)
        {
            jobtime  = 150;
            activef = true;
        }
        console.wait = "Starting";
        console.consoleprint();
    }

    public void wrong()
    {
        jobtime  = 150;
        activef = true;
        console.wait = "Starting";
        console.consoleprint();
    }

    void done()
    {
        console.wait = "The drone reached is home or has ran out of run time";
        console.consoleprint();
    }

    
}
