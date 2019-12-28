using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aggressive : MonoBehaviour
{
    public agent info;
    public GameObject obj;

    public void Start()
    {
        info = new agent();
        info.nameGenerate();
        Debug.Log("agg"+info.ToString());
        info.toCity = "Hanyang";
        info.arrivalCity = "seoul";
        info.prevCity = "seoul";
        //arrive();
    }

    public void arrive()
    {
        obj = GameObject.Find(info.toCity);
        this.transform.parent = obj.transform.Find("aggList");
        info.arrivalCity = info.toCity;
        info.toCity = "none";
   

    }
}
