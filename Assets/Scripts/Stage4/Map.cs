using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    Rigidbody2D rb=>GetComponent<Rigidbody2D>();
    [SerializeField] private float spd;
    [SerializeField] private Transform startPos;
    private void Start()
    {
        rb.velocity = Vector2.left*spd;
    }
    private void Update()
    {
        if (transform.position.x<-41)
        {
            Debug.Log("dd");
            transform.position = startPos.position;
        }
    }
    public void Stop()
    {
        rb.velocity = Vector2.zero;
    }
    public void Play()
    {
        rb.velocity = Vector2.left * spd;

    }
}
