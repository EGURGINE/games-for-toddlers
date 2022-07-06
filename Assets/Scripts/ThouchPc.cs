using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThouchPc : MonoBehaviour
{
    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        if (Input.GetMouseButton(0))
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else transform.GetChild(0).gameObject.SetActive(false);
    }
}
