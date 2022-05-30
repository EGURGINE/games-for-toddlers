using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FitThePieces : MonoBehaviour
{
    [SerializeField] private GameObject[] choice;
    [SerializeField] private Transform[] pos;
    private void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            int ran_1 = Random.Range(0, choice.Length);
            int ran_2 = Random.Range(0, choice.Length);

            GameObject temp;
            temp = choice[ran_1];
            choice[ran_1] = choice[ran_2];
            choice[ran_2] = temp;
        }
        for (int i = 0; i < 4; i++)
        {
            choice[i].transform.position = new Vector2(pos[i].position.x, pos[i].position.y);

        }
    }

}
