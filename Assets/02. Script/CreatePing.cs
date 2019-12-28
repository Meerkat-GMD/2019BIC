using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePing : MonoBehaviour
{
    public bool ping_avail = false;
    public Camera Camera;
    public GameObject ping_object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if (ping_avail && Input.GetMouseButtonDown(0))
        {
            Transform Map = GameObject.Find("Map").GetComponent<Transform>();
            GameObject child;
            Vector2 MousePos;
            MousePos = Input.mousePosition;
            MousePos = Camera.ScreenToWorldPoint(MousePos);
            
            if (MousePos.x > -5f && MousePos.x <5f)
            {
                ping_avail = false;
                child = Instantiate(ping_object, new Vector3(MousePos.x, MousePos.y, 0), Quaternion.identity);
                child.transform.parent = Map;
            }

        }
    }
}
