using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    [SerializeField] private GameObject pc;
    public void MainBtn()
    {
        SceneManager.LoadScene("Main");
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
        Debug.Log("game 3");
    }
    public void Game_4()
    {
        if (PlayerPrefs.GetInt("MaxStageNum") < 4) return;
        Debug.Log("game 4");
    }
    public void Game_5()
    {
        if (PlayerPrefs.GetInt("MaxStageNum") < 5) return;
        Debug.Log("game 5");
    }
}
