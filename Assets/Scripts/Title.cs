using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour
{
    [SerializeField] private GameObject setWnd;
    [SerializeField] private GameObject credit;
    public void MainBtn()
    {
        DOTween.KillAll();
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        SceneManager.LoadScene("Main");
    }
    public void SettingWndOn()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        setWnd.SetActive(true);
    }
    public void SettingWndOff()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        setWnd.SetActive(false);
    }
    public void creditON()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        credit.transform.DOLocalMoveY(0,1).SetEase(Ease.InOutSine);
    }
    public void creditOff()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        credit.transform.DOLocalMoveY(-1099, 1).SetEase(Ease.InOutSine);
    }
    public void TitleBtn()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        DOTween.KillAll();
        SceneManager.LoadScene("Title");
    }
    public void StageSelectBtn()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        DOTween.KillAll();
        SceneManager.LoadScene("Main");
    }
    public void Quit()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        Application.Quit();
    }
}
