using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sel : MonoBehaviour
{
    float time;
    float jobsel = 120;
    public job3 j_3;
    public console console;
    public GameObject box;
    public Text boxs;

    private void Update() {
        time = Time.deltaTime;

        if(time > jobsel)
        {
            j_3.startjob();
            console.wait = j_3.drone;
            console.consoleprint();
        }
    }
}


