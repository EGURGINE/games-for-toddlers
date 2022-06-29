using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class StageManager : MonoBehaviour
{
    [SerializeField] private GameObject setWnd;
    [SerializeField] private Slider exitSlider;
    [SerializeField] private GameObject pc;
    public void MainBtn(float value)
    {
        if (value == 0)
        {
            setWnd.SetActive(true);
            Invoke("ExitSliderControl", 0.5f);
        }
        else exitSlider.value = 1;
    }
    private void ExitSliderControl()
    {
        exitSlider.value = 1;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0)) Instantiate(pc).transform.position =
                  Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
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
