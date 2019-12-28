using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CityInformation : MonoBehaviour
{ 
    //number들 다 필요 없을듯 다 list.Count로 개수 찾기
    public string city_name;
    public int agent_number;
    public List<string> agent_List = new List<string>();
    public List<int> agent_commandList = new List<int>();

    public int educated_number;
    public List<string> educated_List = new List<string>();
    public List<int> educated_commandList = new List<int>();
    
    public List<bool> build = new List<bool>();
    public List<string> building_List = new List<string>();

       
    public CityInformation(string city)
    {
        city_name = city;
        Debug.Log(build);
        build.Add(false);
        build.Add(false);
        build.Add(false);

        building_List.Add("School");
        building_List.Add("Newsroom");
        building_List.Add("Store");
    }

    public void Add_agent(string name)
    {
        agent_number++;
        agent_List.Add(name);
        agent_commandList.Add(0);
    }

    public void Delete_agent(string name)
    {
        foreach (string temp in agent_List )
        {
            if(temp.Equals(name))
            {
                agent_List.Remove(temp);
                agent_number--;
            }
            else
            {
                Debug.Log("There is no agent who has this name");
            }
        }
                
    }

    public void Add_educated(string name)
    {
        //Debug.Log(educated_List);
        educated_List.Add(name);
        educated_commandList.Add(0);
        educated_number++;
    }

    public void Delete_educated(string name)
    {
        foreach (string temp in educated_List)
        {
            if (temp.Equals(name))
            {
                educated_List.Remove(temp);
                educated_number--;
            }
            else
            {
                Debug.Log("There is no educated who has this name");
            }
        }

    }
}
