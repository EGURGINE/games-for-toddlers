using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChoiceSize : MonoBehaviour
{
    [SerializeField] private int stageNum;
    public bool isTrue = false;
    private bool isNot = false;
    private Transform truePos;
    public Transform startPos;
    [SerializeField] private ParticleSystem clearPc;
    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y,9));
    }

    private void OnMouseUp()
    {
        if (isTrue && isNot)
        {
            GameObject.Find("StageManager").GetComponent<FitSize>().choice[GameObject.Find("StageManager").GetComponent<FitSize>().ran].GetComponent<SpriteRenderer>().enabled = false;
            transform.position = truePos.position;
            Instantiate(clearPc).transform.position = transform.position;
            transform.DOScale(new Vector3(transform.localScale.x + 0.1f, transform.localScale.y + 0.1f, 1), 0.5f).SetLoops(2, LoopType.Yoyo).OnComplete(() =>
            {
                StartCoroutine(GameObject.Find("StageManager").GetComponent<FitSize>().ClearDot(stageNum));
                this.GetComponent<SpriteRenderer>().enabled = false;
            });

        }
        else if (!isTrue && isNot) transform.DORotate(new Vector3(0, 0, 15), 0.3f).SetLoops(4, LoopType.Yoyo).OnComplete(() =>
              transform.position = startPos.position);
        else transform.position = startPos.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("True"))
        {
            isNot = true;
            if (this.tag == "True")
            {
                isTrue = true;
                truePos = collision.gameObject.transform;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("True"))
        {
            isNot = false;
            if (this.tag == "True")
            {
                isTrue = false;
            }
        }
    }
}
