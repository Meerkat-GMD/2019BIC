using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingControl : MonoBehaviour
{

    void Start()
    {
    }

    // Update is called once per frame  
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        float distance = 10f;
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,
        Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
        if ((transform.position.x < -5 || transform.position.x > 5))
        {
            Destroy(gameObject);
        }
    }
}
