using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitTheSilhouette2 : MonoBehaviour
{
    [SerializeField] private GameObject[] sizeNum;
    [SerializeField] private Transform[] pos;
    [SerializeField] private int stageNum;
    private int num;
    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            int ran_1 = Random.Range(0, sizeNum.Length);
            int ran_2 = Random.Range(0, sizeNum.Length);

            GameObject temp;
            temp = sizeNum[ran_1];
            sizeNum[ran_1] = sizeNum[ran_2];
            sizeNum[ran_2] = temp;
        }
        for (int i = 0; i < 3; i++)
        {
            sizeNum[i].transform.position = new Vector2(pos[i].position.x, pos[i].position.y);
            sizeNum[i].GetComponent<SilhouetteDrag2>().startPos = pos[i];
        }
    }

    public void ADD(int _num)
    {
        num += _num;
        if(num==3) GameObject.Find("PlayManager").GetComponent<SilhouetteStage>().Stage(stageNum);
    }
}
