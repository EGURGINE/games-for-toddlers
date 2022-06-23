using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Stages;
    [SerializeField] GameObject StageChecker;
    [SerializeField] private Image[] StageNumCheck;
    [SerializeField] GameObject HomeBtn;
    public void Stage(int num)
    {
        if (num == 3)
        {
            StageChecker.SetActive(false);
            HomeBtn.SetActive(true);
            StartCoroutine(gameObject.GetComponent<BalloonSpawner>().Spawn());
            //SceneManager.LoadScene("Main");
            return;
        }
        if (num != 0) Stages[num - 1].SetActive(false);

        StageNumCheck[num].GetComponent<Image>().color = Color.green;
        Stages[num].SetActive(true);
    }
}
