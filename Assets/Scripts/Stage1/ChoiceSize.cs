using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceSize : MonoBehaviour
{
    public bool isTrue = false;
    private Transform truePos;
    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y,10));
    }

    private void OnMouseUp()
    {
        Debug.Log("D");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.tag == "True" && collision.CompareTag("True"))
        {
            truePos = collision.gameObject.transform;
            isTrue = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (this.tag == "True" && collision.CompareTag("True"))
        {
            isTrue = false;
        }
    }
}
