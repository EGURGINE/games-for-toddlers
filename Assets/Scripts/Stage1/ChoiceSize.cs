using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceSize : MonoBehaviour
{
    public bool isTrue = false;
    private Transform truePos;
    private Transform startPos;

    private void Start()
    {
        startPos = transform;
    }
    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y,10));
    }

    private void OnMouseUp()
    {
        if (isTrue)
        {
            transform.position = truePos.position;
            this.GetComponent<BoxCollider2D>().enabled = false;

        }
        else transform.position = startPos.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.tag == "True" && collision.CompareTag("True"))
        {
            isTrue = true;
            truePos = collision.gameObject.transform;
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
