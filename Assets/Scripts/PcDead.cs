using UnityEngine;

public class PcDead : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<ParticleSystem>().Play();
        Destroy(gameObject, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
