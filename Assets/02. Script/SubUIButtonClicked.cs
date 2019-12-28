using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubUIButtonClicked : MonoBehaviour
{
    public GameObject CurrentUI;
    public ShopScrollList Image_kind;
    public GameObject CityObject_Select;
    public GameObject ScrollShop;
    public GameObject CityInfomationUI;
    public GameObject BuildingObject;

    public CityAccess cityinfo;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeftButtonClicked()
    {

    }
    
    public void RightButtonClicked()
    {

    }

    public void ExitButtonClicked()
    {
        CurrentUI.SetActive(false);
        CurrentUI = null;
    }

    public void AgentButtonClicked()
    {
        Image_kind.kind = "agent";
        CityObject_Select.SetActive(false);
        ScrollShop.SetActive(true);
    }
    
    public void EducatedButtonClicked()
    {
        Image_kind.kind = "educated";
        CityObject_Select.SetActive(false);
        ScrollShop.SetActive(true);
    }

    public void BuildingButtonClicked()
    {
        BuildingObject.SetActive(true);
        CityObject_Select.SetActive(false);

    }

    public void CityInfoExitButtonClicked() //안쪽나가는 버튼
    {
        /*
        foreach (CityInformation temp in cityinfo.City_Data)
        {
            if (temp.city_name == Image_kind.cityname)
            {
                for (int i = 0; i < Image_kind.itemList_agent.Count; i++)
                {
                    Item item = Image_kind.itemList_agent[i];
                    //item.itemName = temp.agent_List[i];
                    temp.agent_List[i] = item.itemName;
                    temp.agent_commandList[i] = item.command_value;

                    //Scroll_Item.itemList_agent.Add(item);
                }

                for (int i = 0; i < temp.educated_List.Count; i++)
                {
                    Item item = Image_kind.itemList_educated[i];
                    //item.itemName = temp.educated_List[i];

                    temp.educated_List[i] = item.itemName;
                    temp.educated_commandList[i] = item.command_value;


                    //Scroll_Item.itemList_educated.Add(item);
                }

                break;
            }
        }
        */
        CityObject_Select.SetActive(true);
        BuildingObject.SetActive(false);
        ScrollShop.SetActive(false);
    }

    public void CityInformationButtonClicked() // 밖에 나가는 버튼
    {
        CityObject_Select.SetActive(true);
        ScrollShop.SetActive(false);
        CityInfomationUI.SetActive(false);
        BuildingObject.SetActive(false);
    }
}
