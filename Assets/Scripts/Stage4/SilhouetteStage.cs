using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class SilhouetteStage : MonoBehaviour
{
    [SerializeField] private GameObject[] stages;
    [SerializeField] private GameObject[] maps;
    [SerializeField] private GameObject[] Stages;
    [SerializeField] GameObject StageChecker;
    [SerializeField] private Image[] StageNumCheck;
    [SerializeField] private Sprite clearImage;
    [SerializeField] GameObject HomeBtn;
    private void Start()
    {
        StartCoroutine(NextStage(0));
    }
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

        StageNumCheck[num].rectTransform.DOScale(new Vector2(0.3f, 0.3f), 0.2f).OnComplete(() =>
        {
            StageNumCheck[num].rectTransform.DOScale(new Vector2(1f, 1f), 0.3f);
            StageNumCheck[num].GetComponent<Image>().sprite = clearImage;
        });
        StartCoroutine(NextStage(num));
    }
    public IEnumerator NextStage(int _num)
    {
        foreach (var item in maps)
        {
            item.GetComponent<Map>().Play();
        }
        yield return new WaitForSeconds(2f);
        foreach (var item in maps)
        {
            item.GetComponent<Map>().Stop();
        }
        stages[_num].SetActive(true);
    }
}
