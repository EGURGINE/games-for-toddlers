using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Stages;
    [SerializeField] private Image[] StageNumCheck;
    public void Stage(int num)
    {
        if (num == 5)
        {
            SceneManager.LoadScene("Main");
            return;
        }
        if (num != 0) Stages[num - 1].SetActive(false);

        StageNumCheck[num].GetComponent<Image>().color = Color.green;
        Stages[num].SetActive(true);
    }
}
