using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SilhouetteDrag : MonoBehaviour
{
    [SerializeField] private GameObject trueBg;
    public bool isTrue = false;
    public Transform startPos;
    [SerializeField] private int stageNum;
    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
    }
    private void OnMouseUp()
    {
        if (isTrue)
        {
            transform.position = trueBg.transform.position;
            GameObject.Find("PlayManager").GetComponent<PlayManager>().Stage(stageNum);
        }
        else
        {
            transform.DORotate(new Vector3(0, 0, 15), 0.3f).SetLoops(4, LoopType.Yoyo).OnComplete(() =>
            transform.position = startPos.position);
        }
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
