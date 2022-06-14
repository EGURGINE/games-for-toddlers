using UnityEngine;

public class PcDead : MonoBehaviour
{
    [SerializeField] float cnt;
    void Start()
    {
        gameObject.GetComponent<ParticleSystem>().Play();
        Destroy(gameObject, cnt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
