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
    [SerializeField] GameObject Player;
    private void Start()
    {
        StartCoroutine(NextStage(0));
    }
    public void Stage(int num)
    {
        if (num == 3)
        {
            Player.GetComponent<Animator>().SetBool("isMove", true);
            Player.transform.DOLocalMoveX(30, 8);
            StageChecker.SetActive(false);
            HomeBtn.SetActive(true);
            StartCoroutine(gameObject.GetComponent<BalloonSpawner>().Spawn());
            //SceneManager.LoadScene("Main");
            return;
        }
        if (num != 0) Stages[num - 1].SetActive(false);

        StageNumCheck[num-1].rectTransform.DOScale(new Vector2(0.3f, 0.3f), 0.2f).OnComplete(() =>
        {
            StageNumCheck[num-1].rectTransform.DOScale(new Vector2(1f, 1f), 0.3f);
            StageNumCheck[num-1].GetComponent<Image>().sprite = clearImage;
        });
        StartCoroutine(NextStage(num));
    }
    public IEnumerator NextStage(int _num)
    {
        foreach (var item in maps)
        {
            Player.GetComponent<Animator>().SetBool("isMove", true);
            item.GetComponent<Map>().Play();
        }
        yield return new WaitForSeconds(2f);
        foreach (var item in maps)
        {
            Player.GetComponent<Animator>().SetBool("isMove", false);
            item.GetComponent<Map>().Stop();
        }
        stages[_num].SetActive(true);
    }
}
