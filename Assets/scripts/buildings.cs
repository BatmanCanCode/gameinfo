using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildings : MonoBehaviour
{
    public int warehouse_1 = 26;
    public int warehouse_2 = 45;
    public string warehouse;

    void Start (){
        warehouse = warehouse_1.ToString() + "," + warehouse_2.ToString();
    }
}
