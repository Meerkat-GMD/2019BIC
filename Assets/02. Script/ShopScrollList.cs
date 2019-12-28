using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

[System.Serializable]
public class Item
{
    public int order;
    public string itemName;
    public Dropdown command;
    public int command_value;
    public Sprite icon;
    public float price = 1;
    
}

public class ShopScrollList : MonoBehaviour
{
    public string cityname;
    public string kind;
    public List<Item> itemList_agent;
    public List<Item> itemList_educated;
    public Transform contentPanel;
    public ShopScrollList otherShop;
    public Text myGoldDisplay;
    public SimpleObjectPool ImageObjectPool;

    public float gold = 20f;


    // Use this for initialization
    private void OnEnable()
    { 
        RefreshDisplay();
    }

    void RefreshDisplay()
    {
        myGoldDisplay.text = "Gold: " + gold.ToString();
        RemoveButtons();
        AddButtons();
    }

    private void RemoveButtons()
    {
        while (contentPanel.childCount > 0)
        {
            GameObject toRemove = transform.GetChild(0).gameObject;
            ImageObjectPool.ReturnObject(toRemove);
        }
    }

    private void AddButtons()
    {
        if(kind == "agent")
        {

            for (int i = 0; i < itemList_agent.Count; i++)
            {
                Item item = itemList_agent[i];
                item.order = i;
                GameObject newImage = ImageObjectPool.GetObject();
                newImage.transform.SetParent(contentPanel);

                CharacterScroll sampleImage = newImage.GetComponent<CharacterScroll>();
                sampleImage.kind = this.kind;
                sampleImage.Setup(item, this);

            }
        }
        else if(kind =="educated")
        {
            
            for (int i = 0; i < itemList_educated.Count; i++)
            {
                Item item = itemList_educated[i];
                GameObject newImage = ImageObjectPool.GetObject();
                newImage.transform.SetParent(contentPanel);

                CharacterScroll sampleImage = newImage.GetComponent<CharacterScroll>();
                sampleImage.kind = this.kind;
                sampleImage.Setup(item, this);

            }
        }
    }

    public void TryTransferItemToOtherShop(Item item)
    {
        if (otherShop.gold >= item.price)
        {
            gold += item.price;
            otherShop.gold -= item.price;

            AddItem(item, otherShop);
            RemoveItem(item, this);

            RefreshDisplay();
            otherShop.RefreshDisplay();
            Debug.Log("enough gold");

        }
        Debug.Log("attempted");
    }

    void AddItem(Item itemToAdd, ShopScrollList shopList)
    {
        if(kind=="agent")
        {
            shopList.itemList_agent.Add(itemToAdd);
        }
        else if(kind == "educated")
        {
            shopList.itemList_educated.Add(itemToAdd);
        }
        
    }

    private void RemoveItem(Item itemToRemove, ShopScrollList shopList)
    {
        if (kind == "agent")
        {
            for (int i = shopList.itemList_agent.Count - 1; i >= 0; i--)
            {
                if (shopList.itemList_agent[i] == itemToRemove)
                {
                    shopList.itemList_agent.RemoveAt(i);
                }
            }
        }
        else if (kind == "educated")
        {
            for (int i = shopList.itemList_educated.Count - 1; i >= 0; i--)
            {
                if (shopList.itemList_educated[i] == itemToRemove)
                {
                    shopList.itemList_educated.RemoveAt(i);
                }
            }
        }
        
    }

}