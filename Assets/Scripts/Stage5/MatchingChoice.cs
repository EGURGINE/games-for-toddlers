using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MatchingChoice : MonoBehaviour
{
    [SerializeField] private MatchingGame gm;
    public GameObject trueObj;  
    private void OnMouseDown()
    {
        if (gm.isThouching) return;
        gm.isThouching = true;
        transform.DORotate(Vector3.zero, 0.2f).OnComplete(() => 
        {
            gm.AddCheck(gameObject);
            gm.isThouching = false;
        });
    }

    public void False()
    {
        transform.DORotate(new Vector3(0,180,0), 0.2f);
    }
}
