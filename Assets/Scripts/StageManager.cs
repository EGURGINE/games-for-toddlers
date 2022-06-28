using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class StageManager : MonoBehaviour
{
    [SerializeField] private Slider exitSlider;
    [SerializeField] private GameObject pc;
    public void MainBtn(float value)
    {
        if (value == 0)
        {
            DOTween.KillAll();
            SceneManager.LoadScene("Main");
        }
        else exitSlider.value = 1;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0)) Instantiate(pc).transform.position =
                  Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
    }
    public void Game_1()
    {
        SceneManager.LoadScene("Game1");
    }
    public void Game_2()
    {
        SceneManager.LoadScene("Game2");
    }
    public void Game_3()
    {
        SceneManager.LoadScene("Game3");
    }
    public void Game_4()
    {
        if (PlayerPrefs.GetInt("MaxStageNum") < 4) return;
        SceneManager.LoadScene("Game4");
    }
    public void Game_5()
    {
        if (PlayerPrefs.GetInt("MaxStageNum") < 5) return;
        SceneManager.LoadScene("Game5");
    }
}
