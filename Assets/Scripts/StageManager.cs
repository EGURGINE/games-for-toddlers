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
        SceneManager.LoadScene("1stage");
    }
    public void Game_2()
    {
        SceneManager.LoadScene("2stage");
    }
    public void Game_3()
    {
        SceneManager.LoadScene("3stage");
    }
    public void Game_4()
    {
        //if (PlayerPrefs.GetInt("MaxStageNum") < 4) return;
        SceneManager.LoadScene("4stage");
    }
    public void Game_5()
    {
       // if (PlayerPrefs.GetInt("MaxStageNum") < 5) return;
        SceneManager.LoadScene("5stage");
    }
    public void Game_6()
    {
       // if (PlayerPrefs.GetInt("MaxStageNum") < 6) return;
        SceneManager.LoadScene("6stage");
    }
}
