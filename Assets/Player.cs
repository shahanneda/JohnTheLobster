using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float lastUpdateTime = Time.time;

    public float timeBetweenUpdate = 1f;
    public float moveSpeed = 2;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        if(Time.time > lastUpdateTime + timeBetweenUpdate){
            lastUpdateTime = Time.time;
            rb.AddForce(new Vector2(+0.5f  *moveSpeed, -0.8f  *moveSpeed), ForceMode2D.Impulse);
        }
    }
}
