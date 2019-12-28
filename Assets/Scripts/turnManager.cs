using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnManager : MonoBehaviour
{
    //public int date;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reduceTurnCount()
    {
        
        GameObject[] objArr;
        objArr = GameObject.FindGameObjectsWithTag("AGENT");
        foreach (GameObject ag in objArr)
        {
            if (ag.GetComponent<educated>() == null)
            {
                if (ag.GetComponent<aggressive>().info._turnState.turnCount > 0)
                    ag.GetComponent<aggressive>().info._turnState.turnCount--;
            }
            else
            {
                if (ag.GetComponent<educated>().info._turnState.turnCount > 0)
                    ag.GetComponent<educated>().info._turnState.turnCount--;
                Debug.Log(ag.GetComponent<educated>().info._turnState.turnCount);
            }
        }
       
    }
}
