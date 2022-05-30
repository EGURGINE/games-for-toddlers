using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManager : MonoBehaviour
{
    [SerializeField] private GameObject pc;
    public void ExitBtn()
    {
        SceneManager.LoadScene("Main");
    }

    private void Update()
    {
       if(Input.GetMouseButton(0)) Instantiate(pc).transform.position = 
                Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
    }
}
