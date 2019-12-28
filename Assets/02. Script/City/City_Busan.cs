using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class City_Busan : MonoBehaviour
{
    public Sprite cityimage1;
    public Sprite cityimage2;
    public CityAccess city;
    public CityInformation cityinfo = new CityInformation("Busan");
    public GameObject Enable_School;
    public GameObject Enable_Newsroom;
    public GameObject Enable_Store;
    public GameObject NewsUI;
    public List<Sprite> news;
    public showmethemoney money;
    public ShopScrollList remove_button;
    GameObject[] objArr;
    Transform loca1;
    Transform loca2;
    public int Day;

    public bool check;
    private int build_count = 3;
    // Start is called before the first frame update
    private void OnEnable()
    {
        
        city.AddCity("Busan");
    }

    void Start()
    {
        money = GameObject.Find("Money").GetComponent<showmethemoney>();
        check = false;
        cityinfo = gameObject.GetComponent<CityInformation>();
        cityinfo.build.Add(false);
        cityinfo.build.Add(false);
        cityinfo.build.Add(false);

        cityinfo.building_List.Add("School");
        cityinfo.building_List.Add("Newsroom");
        cityinfo.building_List.Add("Store");

        //cityinfo.agent_List.Add("나재흠");
        cityinfo.Add_agent("나재흠");
        cityinfo.Add_agent("방심보");
        cityinfo.Add_agent("신형섭");
        cityinfo.Add_agent("방취하");
        cityinfo.Add_educated("정규훈");
        cityinfo.Add_educated("취하방");
    }

    // Update is called once per frame
    void Update()
    {
        enable_building();
        if(Day == 0)
        {
            
            objArr = GameObject.FindGameObjectsWithTag("AGENT");
            loca1 = GameObject.Find("Masan").GetComponent<Transform>();
            loca2 = GameObject.Find("Busan").GetComponent<Transform>();
            foreach (GameObject ag in objArr)
            {
                if (ag.GetComponent<educated>() == null)
                {
                    ag.GetComponent<aggressive>().info.toCity="Busan";
                    ag.GetComponent<aggressive>().info.arrivalCity = "Masan";
                    ag.GetComponent<Transform>().position= loca1.position;
                    

                }
                else
                {
                    ag.GetComponent<educated>().info.toCity = "Hanyang";
                    ag.GetComponent<educated>().info.arrivalCity = "Busan";
                    ag.GetComponent<Transform>().position = loca2.position;
                }
            }
            NewsUI.GetComponent<Image>().sprite = news[0];
            check = false;
        }
        else if(Day == 1)
        {

            loca1 = GameObject.Find("Hanyang").GetComponent<Transform>();
            loca2 = GameObject.Find("Busan").GetComponent<Transform>();
            foreach (GameObject ag in objArr)
            {
                if (ag.GetComponent<educated>() == null)
                {
                    ag.GetComponent<aggressive>().arrive();
                    ag.GetComponent<aggressive>().info.toCity = "Hanyang";
                    ag.GetComponent<aggressive>().info.arrivalCity = "Busan";
                    ag.GetComponent<Transform>().position = loca2.position;


                }
                else
                {
                    ag.GetComponent<educated>().arrive();
                    ag.GetComponent<educated>().info.toCity = "Masan";
                    ag.GetComponent<educated>().info.arrivalCity = "Hanyang";
                    ag.GetComponent<Transform>().position = loca1.position;
                }
            }


            if (check)
            {

                if(cityinfo.build[0])
                {
                    agent ag = new agent();
                    ag.nameGenerate();
                    cityinfo.Add_educated(ag.agName);
                }
                if(cityinfo.build[1])
                {
                    agent ag = new agent();
                    ag.nameGenerate();
                    cityinfo.Add_agent(ag.agName);
                }
                if(cityinfo.build[2])
                {
                    money.money += 50;
                }
            }
            NewsUI.GetComponent<Image>().sprite = news[1];
            check = false;
        }
        else if(Day == 2)
        {
            loca1 = GameObject.Find("Hanyang").GetComponent<Transform>();
            loca2 = GameObject.Find("Masan").GetComponent<Transform>();
            foreach (GameObject ag in objArr)
            {
                if (ag.GetComponent<educated>() == null)
                {
                    ag.GetComponent<aggressive>().arrive();
                    ag.GetComponent<aggressive>().info.toCity = "Hanyang";
                    ag.GetComponent<aggressive>().info.arrivalCity = "Busan";
                    ag.GetComponent<Transform>().position = loca1.position;


                }
                else
                {
                    ag.GetComponent<educated>().arrive();
                    ag.GetComponent<educated>().info.toCity = "Masan";
                    ag.GetComponent<educated>().info.arrivalCity = "Hanyang";
                    ag.GetComponent<Transform>().position = loca2.position;
                }
            }
            if (check)
            {

                if (cityinfo.build[0])
                {
                    agent ag = new agent();
                    ag.nameGenerate();
                    cityinfo.Add_educated(ag.agName);
                }
                if (cityinfo.build[1])
                {
                    agent ag = new agent();
                    ag.nameGenerate();
                    cityinfo.Add_agent(ag.agName);
                }
                if (cityinfo.build[2])
                {
                    money.money += 50;
                }
            }
            //적 출현
            NewsUI.GetComponent<Image>().sprite = news[2];
            gameObject.GetComponent<SpriteRenderer>().sprite = cityimage2;
            check = false;
        }
        else if (Day == 3)
        {
            Destroy(objArr[0]);
            if (check)
            {

                if (cityinfo.build[0])
                {
                    agent ag = new agent();
                    ag.nameGenerate();
                    cityinfo.Add_educated(ag.agName);
                }
                if (cityinfo.build[1])
                {
                    agent ag = new agent();
                    ag.nameGenerate();
                    cityinfo.Add_agent(ag.agName);
                }
                if (cityinfo.build[2])
                {
                    money.money += 50;
                }
            }
            if (cityinfo.agent_commandList[0] == 0)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = cityimage1;
            }
            check = false;
            
        }

    }

    public void enable_building()
    {
        if (cityinfo.build[0])
        {
            Enable_School.GetComponent<Button>().interactable = false;
        }
        else
        {
            Enable_School.GetComponent<Button>().interactable = true;
        }

        if (cityinfo.build[1])
        {
            Enable_Newsroom.GetComponent<Button>().interactable = false;
        }
        else
        {
            Enable_Newsroom.GetComponent<Button>().interactable = true;
        }

        if (cityinfo.build[2])
        {
            Enable_Store.GetComponent<Button>().interactable = false;
        }
        else
        {
            Enable_Store.GetComponent<Button>().interactable = true;
        }
    }

    public void build_school()
    {
        showmethemoney gui = GameObject.Find("Money").GetComponent<showmethemoney>();
        gui.money -= 10;
        cityinfo.build[0] = true;
    }

    public void build_Newsroom()
    {
        showmethemoney gui = GameObject.Find("Money").GetComponent<showmethemoney>();
        gui.money -= 20;
        cityinfo.build[1] = true;

    }

    public void build_Store()
    {
        showmethemoney gui = GameObject.Find("Money").GetComponent<showmethemoney>();
        gui.money -= 30;

        cityinfo.build[2] = true;
    }
}
