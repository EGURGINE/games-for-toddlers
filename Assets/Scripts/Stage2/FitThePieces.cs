using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class FitThePieces : MonoBehaviour
{
    [SerializeField] private GameObject[] choice;
    [SerializeField] private Transform[] pos;
    [SerializeField] private int stageNum;
    private int piecesClear = 0;
    private void Start()
    {
        for (int i = 0; i < choice.Length; i++)
        {
            int ran_1 = Random.Range(0, choice.Length);
            int ran_2 = Random.Range(0, choice.Length);

            GameObject temp;
            temp = choice[ran_1];
            choice[ran_1] = choice[ran_2];
            choice[ran_2] = temp;
        }
        for (int i = 0; i < choice.Length; i++)
        {
            choice[i].transform.position = new Vector2(pos[i].position.x, pos[i].position.y);
            choice[i].GetComponent<Pieces>().startPos = pos[i];
        }
    }
    public void IsClear(int num)
    {
        piecesClear += num;
        if (piecesClear==choice.Length)
        {
            GameObject.Find("PlayManager").GetComponent<PlayManager>().Stage(stageNum);
        }
    }


}
