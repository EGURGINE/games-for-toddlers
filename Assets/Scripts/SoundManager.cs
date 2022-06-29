using System.Collections.Generic;
using UnityEngine;

public enum Sound_Effect
{
    BUTTON,
    TRUE,
    CLEAR,
    BOOM
}


public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;
    public static SoundManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SoundManager>();
            }
            return instance;
        }
    }

    [SerializeField] private List<AudioClip> sfxs;

    public void PlaySound(Sound_Effect soundType)
    {
        GameObject go = new GameObject("sound");

        AudioSource audioSource = go.AddComponent<AudioSource>();
        audioSource.volume = Setting.Instance.volume;
        audioSource.clip = sfxs[(int)soundType];
        audioSource.Play();

        Destroy(go, audioSource.clip.length);
    }
}
