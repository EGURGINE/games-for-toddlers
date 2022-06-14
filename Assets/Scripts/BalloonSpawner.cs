using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BalloonSpawner : MonoBehaviour
{
    [SerializeField] GameObject HomeBtn;
    [SerializeField] GameObject Balloon;
    
    int num;
    public void NotBalloon(int _num)
    {
        num +=_num;
        if (num==10)
        {
            HomeBtn.GetComponent<RectTransform>().DOAnchorPos( Vector2.zero,1f).SetEase(Ease.InBack);
        }
    }
    public IEnumerator Spawn()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(Random.Range(0, 0.8f));
            Instantiate(Balloon).transform.position = new Vector2(Random.Range(-8,8), -9);

        }
    }
}
