using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChoiceSize : MonoBehaviour
{
    [SerializeField] private int stageNum;
    public bool isTrue = false;
    private Transform truePos;
    public Transform startPos;

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
            GameObject.Find("PlayManager").GetComponent<PlayManager>().Stage(stageNum);
        }
        else transform.DORotate(new Vector3(0, 0, 15), 0.3f).SetLoops(4, LoopType.Yoyo).OnComplete(() =>
             transform.position = startPos.position);
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
