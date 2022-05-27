using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    public int maxStage = 3;

    private void Awake()
    {
        Instance = this;
        maxStage = PlayerPrefs.GetInt("MaxStageNum");
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (maxStage >= 5) return;
            maxStage++;
            PlayerPrefs.SetInt("MaxStageNum", maxStage);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            maxStage = 3;
            PlayerPrefs.SetInt("MaxStageNum", maxStage);
        }
    }
}
