using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class showmethemoney : MonoBehaviour
{
    public TextMeshProUGUI gui = new TextMeshProUGUI();
    public int money = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gui.text = "돈 : " + money.ToString();
    }
}
