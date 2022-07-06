using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class StageManager : MonoBehaviour
{
    [SerializeField] private Slider exitSlider;
    public void MainBtn(float value)
    {
        if (value == 0)
        {
            SceneManager.LoadScene("Main");
        }
        else exitSlider.value = 1;
    }
    public void Game_1()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        StartCoroutine(GoToStage(2));
    }
    public void Game_2()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        StartCoroutine(GoToStage(3));
    }
    public void Game_3()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        StartCoroutine(GoToStage(4));
    }
    public void Game_4()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        StartCoroutine(GoToStage(5));
        //if (PlayerPrefs.GetInt("MaxStageNum") < 4) return;
    }
    public void Game_5()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        StartCoroutine(GoToStage(6));
        // if (PlayerPrefs.GetInt("MaxStageNum") < 5) return;
    }
    public void Game_6()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        StartCoroutine(GoToStage(7));
        // if (PlayerPrefs.GetInt("MaxStageNum") < 6) return;
    }
    private IEnumerator GoToStage(int _num)
    {
        yield return new WaitForSeconds(0.21f);
        SceneManager.LoadScene(_num);
    }
}
