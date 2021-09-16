using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class job1 : MonoBehaviour
{
    public int id;
    public int point;
    public team team;
    public float wait;
    public bool p1,p2,p3,p4,p5, times;

    public float time, jobtime;
    public console console;
    string re;

    public storeage store;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wait += Time.deltaTime;
        //id = Random.Range(1000, 9999);
        if(times == true)
        {
            time += Time.deltaTime;
        }

        if(time > jobtime)
        {
            team.active = false;
            reward();
            times = false;
            jobtime = 0;
            time = 0;
        }
    }

    public void job()
    {
        if(team.active == true)
        {
            console.wait = "Your Team Is On A Job";
            console.consoleprint();
        }else
             if(team.active == false)
             {
                    id = Random.Range(1000, 9999);
                    point = Random.Range(1, 6);
            }
        }



    public void jobstart()
    {
        team.active = true;
        times = true;
        jobtime = 60;
    }

    void reward()
    {
        if(re.Contains("drone"))
        {
            store.drone += 1;
        }else
        if(re.Contains("congo stick"))
        {
            store.congostick += 1;
        }else
        if(re.Contains("Wifi Cam"))
        {
            store.wificam += 1;
        }else
        if(re.Contains("TV"))
        {
            store.tv += 1;
        }else
        if(re.Contains("Smart clock"))
        {
            store.smartclock += 1;
        }
    }

    public int s;
    void jobad()
    {
        s = Random.Range(1, 6);
        if(s == 1 ){re = "drone";} 
        if(s==2){re = "congo stick";}
        if(s==3){re = "Wifi Cam";}
        if(s==4){re = "TV";}
        if(s==5){re = "Smart clock";}
        
    }

    

    
}
