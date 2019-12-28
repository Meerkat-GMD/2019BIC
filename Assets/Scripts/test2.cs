using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{

    public test b;
    // Start is called before the first frame update
    void Start()
    {
        b = new test();
    }
    public void foo1()
    {
        b.a.Add(1);
    }

    public void print()
    {
        foreach (int i in b.a)
        {
            print(i);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
