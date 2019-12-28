using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Hanyang : MonoBehaviour
{
    public CityAccess city;
    public CityInformation cityinfo;
    // Start is called before the first frame update
    private void OnEnable()
    {
        cityinfo = gameObject.GetComponent<CityInformation>();
        city.AddCity("Hanyang");

    }

    void Start()
    {

        //cityinfo.agent_List.Add("나재흠");
        cityinfo.Add_agent("나재흠");
        cityinfo.Add_agent("ㅁㄴㅇㄹㅇㅁ");
        cityinfo.Add_agent("ㅁㄴㅇ");
        cityinfo.Add_agent("ㅁ");
        cityinfo.Add_educated("정규훈");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
