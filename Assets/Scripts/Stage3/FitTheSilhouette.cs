using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitTheSilhouette : MonoBehaviour
{
    [SerializeField] private GameObject[] sizeNum;
    [SerializeField] private Transform[] pos;
    private void Start()
    {
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
            sizeNum[i].transform.position = new Vector2(pos[i].position.x, pos[i].position.y);
            sizeNum[i].GetComponent<SilhouetteDrag>().startPos = pos[i];
        }
    }
}
