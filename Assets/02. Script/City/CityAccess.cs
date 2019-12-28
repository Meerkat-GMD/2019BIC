using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityAccess : MonoBehaviour
{
    public List<CityInformation> City_Data = new List<CityInformation>();
    CityInformation temp_city;
    public void AddCity(string name)
    {
        temp_city = GameObject.Find(name).GetComponent<CityInformation>();
        temp_city.city_name = name;
        City_Data.Add(temp_city);
    }

    void Start()
    {
        //temp_city = new CityInformation("adf");
        //City_Data.Add(temp_city);
    }

    void Update()
    {
        //Debug.Log(City_Data[0]);
    }

}
