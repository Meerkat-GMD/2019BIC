using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class building : MonoBehaviour
{
    public turnState _turnState;
    public string kind;
    public bool isBuild;
    public int maxTurn=3;
    void Start()
    {
        
    }

    public building(string skind)
    {
        _turnState.isTurning = false;
        _turnState.turnCount = 0;
        isBuild = false;
        kind = skind;

    }
    public void popResource()
    {
        if (kind=="store")
        {

        }
        else if (kind == "school")
        {

        }
        else if(kind=="newsRoom")
        {

        }
        _turnState.turnCount = maxTurn;
    }

}


