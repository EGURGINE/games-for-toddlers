using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Setting : MonoBehaviour
{
    private static Setting instance;
    public static Setting Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Setting>();
            }
            return instance;
        }
    }

    [SerializeField] GameObject settingWnd;
    [SerializeField] private AudioSource bgm;
    public float volume;

    private void Awake()
    {
        float curSfx = 1;

        if (PlayerPrefs.HasKey("Volume"))
            curSfx = PlayerPrefs.GetFloat("Volume");

        Debug.Log(curSfx);
        bgm.volume = curSfx / 2;
        volume = curSfx;
    }
    

    public void SetMusicVolume(float setVolume)
    {
        bgm.volume = setVolume / 2;
        volume = setVolume;
        PlayerPrefs.SetFloat("Volume", setVolume);
    }

    public void InExitBtn()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        settingWnd.SetActive(false);
    }
    public void TitleExitBtn()
    {
        SoundManager.Instance.PlaySound(Sound_Effect.BUTTON);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        settingWnd.SetActive(false);
    }

    public void MainExitBtn()
    {
        SceneManager.LoadScene("Title");
    }
}
