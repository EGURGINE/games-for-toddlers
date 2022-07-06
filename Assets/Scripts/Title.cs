using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour
{
    [SerializeField] private GameObject credit;
    private int choice = 1;
    [SerializeField] GameObject[] settingWnd;
    public void MainBtn()
    {
        DOTween.KillAll();
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        Invoke("GoMain", 0.21f);
    }
    private void GoMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void LeftBtn()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        if (choice == 0) choice = 2;
        else choice--;
        foreach (var item in settingWnd)
        {
            item.SetActive(false);
        }
        settingWnd[choice].SetActive(true);
    }
    public void RightBtn()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        if (choice == 2) choice = 0;
        else choice++;
        foreach (var item in settingWnd)
        {
            item.SetActive(false);
        }
        settingWnd[choice].SetActive(true);
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
        DOTween.KillAll();
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        Invoke("GoToTitle", 0.21f);
    }
    private void GoToTitle()
    {
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
