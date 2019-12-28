using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public turnState _turnState;
    public int patrol;                  //클래스

    // Start is called before the first frame update
    void Start()
    {
        _turnState.isTurning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(_turnState.isTurning==true)
        {
            
        }
        else
        {

        }
    }
}
