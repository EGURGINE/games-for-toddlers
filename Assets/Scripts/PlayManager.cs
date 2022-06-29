using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class PlayManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Stages;
    [SerializeField] GameObject StageChecker;
    [SerializeField] private Image[] StageNumCheck;
    [SerializeField] private Sprite clearImage;
    [SerializeField] GameObject HomeBtn;
    public void Stage(int num)
    {
        if (num == Stages.Length)
        {
            StageChecker.SetActive(false);
            HomeBtn.SetActive(true);
            StartCoroutine(gameObject.GetComponent<BalloonSpawner>().Spawn());
            return;
        }
        if (num != 0) Stages[num - 1].SetActive(false);

        StageNumCheck[num].rectTransform.DOScale(new Vector2(0.3f, 0.3f), 0.2f).OnComplete(() =>
          {
              StageNumCheck[num].rectTransform.DOScale(new Vector2(1f, 1f), 0.3f);
              StageNumCheck[num].GetComponent<Image>().sprite = clearImage;
          });
        Stages[num].SetActive(true);
    }
}
