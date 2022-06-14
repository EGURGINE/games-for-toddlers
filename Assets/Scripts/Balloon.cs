using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Balloon : MonoBehaviour
{
    [SerializeField] Sprite[] color;
    [SerializeField] ParticleSystem pc;
    void Start()
    {
        transform.DOLocalMoveY(-2, 3f).OnComplete(
            () => transform.DOLocalMoveY(transform.position.y - 1f,1f).SetLoops(-1,LoopType.Yoyo)) ;
        GetComponent<SpriteRenderer>().sprite = color[Random.Range(0, color.Length)];
    }
    private void OnMouseDown()
    {
        Instantiate(pc).transform.position =  new Vector2(transform.position.x,transform.position.y+2.3f);
        Destroy(gameObject);
    }
    private void OnDestroy()
    {
        GameObject.Find("PlayManager").GetComponent<BalloonSpawner>().NotBalloon(1);
    }
}
