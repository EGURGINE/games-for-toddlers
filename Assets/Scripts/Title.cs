using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour
{
    [SerializeField] private Image title;
    [SerializeField] private GameObject credit;
    void Start()
    {
        title.rectTransform.DOLocalMoveY(200, 1).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
        //    SceneManager.LoadScene("Main");
        //}
    }
    public void creditON()
    {
        credit.transform.DOLocalMoveY(0,1).SetEase(Ease.InOutSine);
    }
    public void creditOff()
    {
        credit.transform.DOLocalMoveY(-1099, 1).SetEase(Ease.InOutSine);
    }
}
