using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Pieces : MonoBehaviour
{
    [SerializeField] private GameObject trueBg;
    public bool isTrue = false;
    public Transform startPos;
    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10));
    }
    private void OnMouseUp()
    {
        if (isTrue)
        {
            transform.position = trueBg.transform.position;
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
        else transform.position = startPos.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == trueBg) isTrue = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == trueBg) isTrue = false;
    }
}
