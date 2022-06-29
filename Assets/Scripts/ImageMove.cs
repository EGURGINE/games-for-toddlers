using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class ImageMove : MonoBehaviour
{

    [SerializeField] private float cnt;
    void Start()
    {
        gameObject.GetComponent<Image>().rectTransform.DOLocalMoveY(100, cnt).SetLoops(-1, LoopType.Yoyo);
    }
}
