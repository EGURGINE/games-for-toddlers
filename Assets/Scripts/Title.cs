using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour
{
  
    [SerializeField] private GameObject credit;
    public void MainBtn()
    {
        DOTween.KillAll();
        SceneManager.LoadScene("Main");
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
