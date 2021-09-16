using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class job2 : MonoBehaviour
{
    //sell
    public playerinfo info;
    public storeage store;
    int dronemin =100, dronemax =500;
    int congostickmin=20, congostickmax = 40;
    int tvmin = 100, tvmax = 800, smartclockmin = 20,smartclockmax=45,wificammin = 50,wificammax = 300;
    int price;
    public Text offer;
    public GameObject pop;
    

    public int s ;
    public void random()
    {
        s = Random.Range(1, 6);
        if(s == 1 && store.drone > 0){price = Random.Range(dronemin, dronemax );offer.text = "I would like to buy 1 drone for " + price;pop.SetActive(true);}
        if(s==2 && store.congostick > 0){price = Random.Range(congostickmin, congostickmax) ;offer.text = "I would like to buy 1 congo stick for "  +price;pop.SetActive(true);}
        if(s==3 && store.tv > 0){price = Random.Range(tvmin, tvmax ); offer.text = " I would like to buy 1 tv for " +price;pop.SetActive(true);}
        if(s==4 && store.smartclock > 0){price = Random.Range(smartclockmin, smartclockmax ); offer.text = "i would like to buy 1 Smart clock for " + price;pop.SetActive(true);}
        if(s==5 && store.wificam > 0){price = Random.Range(wificammin, wificammax ); offer.text = "I would like to buy 1 Wifi cam for " + price;pop.SetActive(true);}
        

    }

    public void take()
    {
        if(s == 1 ){info.cash += price; store.drone -= 1;};
        if(s==2){info.cash += price; store.congostick -= 1;};
        if(s==3){info.cash += price; store.tv -= 1;};
        if(s==4){info.cash += price; store.smartclock -= 1;};
        if(s==5){info.cash += price; store.wificam -= 1;};
        pop.SetActive(false);
    }

    
}