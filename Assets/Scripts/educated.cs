using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class educated : MonoBehaviour
{
    public agent info;
    public GameObject obj;
    

 
    public void Start()
    {
        info = new agent();
        info.nameGenerate();
        Debug.Log("edu" + info.ToString());
        info.toCity = "busan";
        info.arrivalCity = "seoul";
        info.prevCity = "seoul";

        info._turnState.turnCount = 10;
       // info.move(this.gameObject);
        Debug.Log(info.ToString());
        
    }


    public void arrive()
    { 
        obj = GameObject.Find(info.toCity);
        this.transform.parent = obj.transform.Find("eduList");
        info.arrivalCity = info.toCity;
        info.toCity = "none";
    }
    
}


