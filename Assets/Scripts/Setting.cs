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
    [SerializeField] Slider bgmS;
    [SerializeField] Slider sfxS;
    [SerializeField] private AudioSource bgm;
    public float volume;

    private void Awake()
    {
        bgm.volume = PlayerPrefs.GetFloat("BgmVolume");
        bgmS.value = bgm.volume;
        volume = PlayerPrefs.GetFloat("Volume");
        sfxS.value = volume;
    }
    

    public void SetMusicVolume(float setVolume)
    {
        volume = setVolume;
        PlayerPrefs.SetFloat("Volume", setVolume);
    }

    public void SetBgmVolume(float setVolume)
    {
        bgm.volume = setVolume / 2;
        PlayerPrefs.SetFloat("BgmVolume", setVolume);
    }
}
