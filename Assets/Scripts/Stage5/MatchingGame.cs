using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchingGame : MonoBehaviour
{
    [SerializeField] private GameObject[] sizeNum;
    [SerializeField] private Transform[] pos;
    public bool isThouching;
    [SerializeField] private int stageNum;
    private int num;
    List<GameObject> check = new List<GameObject>();
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            int ran_1 = Random.Range(0, sizeNum.Length);
            int ran_2 = Random.Range(0, sizeNum.Length);

            GameObject temp;
            temp = sizeNum[ran_1];
            sizeNum[ran_1] = sizeNum[ran_2];
            sizeNum[ran_2] = temp;
        }
        for (int i = 0; i < 10; i++)
        {
            sizeNum[i].transform.position = new Vector2(pos[i].position.x, pos[i].position.y);
        }
    }
    private void CheckNum(int _num)
    {
        num += _num;
        if (num >= 5) GameObject.Find("PlayManager").GetComponent<PlayManager>().Stage(stageNum);
    }

    public void AddCheck(GameObject _obj)
    {
        check.Add(_obj);
        if (check.Count == 2)
        {
            if (check[0].GetComponent<MatchingChoice>().trueObj == check[1])
            {
                check[0].GetComponent<BoxCollider2D>().enabled = false;
                check[1].GetComponent<BoxCollider2D>().enabled = false;

                CheckNum(1);
                check.Clear();
            }
            else
            {
                check[0].GetComponent<MatchingChoice>().False();
                check[1].GetComponent<MatchingChoice>().False();

                check.Clear();
            }
        }
    }
}