using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonClicked : MonoBehaviour
{
    public GameObject NewsUI;
    public GameObject LetterUI;
    public GameObject InformationUI;

    public SubUIButtonClicked Send;
    public CreatePing ping_image;
    // Start is called before the first frame update
    void Start()
    {
        Send = gameObject.GetComponent<SubUIButtonClicked>();
        ping_image = gameObject.GetComponent<CreatePing>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewsButtonClicked()
    {
        NewsUI.SetActive(true);
        Send.CurrentUI = NewsUI;
        
  //      GameObject.Find("NewsButton").GetComponent<Button>().taSrgetGraphic = 
    }

    public void PingRED_ButtonClicked()
    {
        gameObject.GetComponent<CreatePing>().ping_avail = !gameObject.GetComponent<CreatePing>().ping_avail;
        ping_image.ping_object = GameObject.Find("Ping_RED");
    }

    public void PingBLUE_ButtonClicked()
    {
        gameObject.GetComponent<CreatePing>().ping_avail = !gameObject.GetComponent<CreatePing>().ping_avail;
        ping_image.ping_object = GameObject.Find("Ping_BLUE");
    }

    public void PingYELLOW_ButtonClicked()
    {
        gameObject.GetComponent<CreatePing>().ping_avail = !gameObject.GetComponent<CreatePing>().ping_avail;
        ping_image.ping_object = GameObject.Find("Ping_YELLOW");
    }

    public void nextTurn()
    {
        City_Busan bussan = GameObject.Find("Busan").GetComponent<City_Busan>();
        letter temp = GameObject.Find("LetterManager").GetComponent<letter>();
        temp.goNext();
        bussan.Day++;
        bussan.check = true;
    }

    public void LetterButtonClicked()
    {
        LetterUI.SetActive(true);
        Send.CurrentUI = LetterUI;
    }

    public void InformationButtonClicked()
    {
        InformationUI.SetActive(true);
        Send.CurrentUI = InformationUI;
    }
}
