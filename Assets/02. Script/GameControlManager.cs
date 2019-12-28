using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlManager : MonoBehaviour
{
    Camera _mainCam = null;
    public GameObject CityInformationUI;
    public CityAccess cityinfo;
    public ShopScrollList Scroll_Item;
    void Awake()
    {
        _mainCam = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MaxDistance = 15f;
        RaycastHit2D hit;

        Vector3 MousePosition = Input.mousePosition;

        MousePosition = _mainCam.ScreenToWorldPoint(MousePosition);

        Debug.DrawRay(MousePosition, transform.forward * 10, Color.red, 0.3f);

        hit = Physics2D.Raycast(MousePosition, transform.forward, MaxDistance);
        try
        {
            switch (hit.transform.gameObject.tag)
            {
                case "PING":
                    //if(Input.GetMouseButtonDown(0))
                        //hit.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                    break;
                case "CITY":
                    if (Input.GetMouseButtonDown(0))
                    {
                        //Debug.Log(GameObject.Find("CityInformationCenter").GetComponent<CityAccess>().City_Data[0].city_name);
                        foreach (CityInformation temp in cityinfo.City_Data)
                        {
                            if (temp.city_name == hit.transform.gameObject.name)
                            {
                                 Scroll_Item.cityname = temp.city_name;
                                for (int i =0; i < temp.agent_List.Count; i++)
                                {
                                    Item item = new Item();
                                    item.itemName = temp.agent_List[i];
                                    item.command_value = temp.agent_commandList[i];

                                    Scroll_Item.itemList_agent.Add(item);
                                   
                                }

                                for (int i = 0; i < temp.educated_List.Count; i++)
                                {
                                    Item item = new Item();
                                    item.itemName = temp.educated_List[i];
                                    item.command_value = temp.educated_commandList[i];

                                    Scroll_Item.itemList_educated.Add(item);
                                }
                                CityInformationUI.SetActive(true);
                                break;
                            }
                        }
                    }
                    break;
                default:
                    Debug.Log("Noting Click");
                    break;
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex);
        }
        
    }
}
