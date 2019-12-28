using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test3 : MonoBehaviour
{
    public test c;
    // Start is called before the first frame update
    void Start()
    {
        c = new test();
    }
    public void foo2()
    {
        c.a.Add(2);
    }

    public void print()
    {
        foreach(int i in c.a)
        {
            print(i);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
