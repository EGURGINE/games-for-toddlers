using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class FitSize : MonoBehaviour
{
    [SerializeField] private GameObject[] choice;
    [SerializeField] private GameObject[] sizeNum;
    [SerializeField] private Transform[] pos;
    private int ran;
    private void Start()
    {
        ran = Random.Range(0, choice.Length);
        choice[ran].GetComponent<SpriteRenderer>().enabled = false;
        choice[ran].AddComponent<BoxCollider2D>().isTrigger = true;
        choice[ran].tag = "True";
        sizeNum[ran].tag = "True";
        for (int i = 0; i < 4; i++)
        {
            int ran_1 = Random.Range(0, sizeNum.Length);
            int ran_2 = Random.Range(0, sizeNum.Length);

            GameObject temp;
            temp = sizeNum[ran_1];
            sizeNum[ran_1] = sizeNum[ran_2];
            sizeNum[ran_2] = temp;
        }
        for (int i = 0; i < 4; i++)
        {
            sizeNum[i].transform.position = new Vector2(pos[i].position.x,pos[i].position.y-8);
            sizeNum[i].GetComponent<ChoiceSize>().startPos = pos[i];
        }

        StartDot();
    }

    private void StartDot()
    {
        for (int i = 0; i < choice.Length; i++)
        {
            choice[i].transform.DOLocalMoveY(2, 0.3f).SetEase(Ease.InSine).SetLoops(2, LoopType.Yoyo);
            choice[i].transform.DORotate(new Vector3(0, 0, 360), 0.2f, RotateMode.FastBeyond360);

            sizeNum[i].transform.DOLocalMoveY(pos[i].transform.position.y, 0.3f).SetEase(Ease.InSine);
        }
    }
    public IEnumerator ClearDot(int num)
    {
        choice[ran].GetComponent<SpriteRenderer>().enabled = true;

        for (int i = 0; i < choice.Length; i++)
        {
            choice[i].transform.DOLocalMoveY(2, 0.3f).SetEase(Ease.InSine).SetLoops(2, LoopType.Yoyo);
            choice[i].transform.DORotate(new Vector3(0, 0, 360), 0.2f, RotateMode.FastBeyond360);

            sizeNum[i].transform.DOLocalMoveY(-8, 0.3f).SetEase(Ease.InSine);
        }
        
        yield return new WaitForSeconds(0.6f);
        GameObject.Find("PlayManager").GetComponent<PlayManager>().Stage(num);
    }
}
