using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterScroll : MonoBehaviour
{

    public string kind;
    public Image ImageComponent;
    public Text nameLabel;
    public Image iconImage;
    public Dropdown command;
    public ShopScrollList dropdown_data;


    private Item item;
    private ShopScrollList scrollList;

    // Use this for initialization
    void Start()
    {
        dropdown_data = GameObject.Find("Content").GetComponent<ShopScrollList>();

    }
    private void OnEnable()
    {
        command.ClearOptions();
    }

    public void Setup(Item currentItem, ShopScrollList currentScrollList)
    {
        item = currentItem;
        nameLabel.text = item.itemName;
        iconImage.sprite = item.icon;
        if (kind == "agent")
        {
            List<string> m_DropOptions = new List<string> { "대기", "이동", "의열투쟁" };
            command.AddOptions(m_DropOptions);
        }
        else if (kind == "educated")
        {
            List<string> m_DropOptions = new List<string> { "대기", "이동", "교육" };
            command.AddOptions(m_DropOptions);
        }
        command.value = item.command_value;
        scrollList = currentScrollList;

    }

    public void HandleClick()
    {
        scrollList.TryTransferItemToOtherShop(item);
    }

    public void ChangeDropDown()
    {
        if(kind=="agent")
        {
            dropdown_data.itemList_agent[item.order].command_value = command.value;
        }
        else if(kind =="educated")
        {
            dropdown_data.itemList_educated[item.order].command_value = command.value;
        }
       
    }
}
