using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float lastUpdateTime;

    public float timeBetweenUpdate = 1f;
    public float moveSpeed = 2;


    void Start()
    {
        lastUpdateTime = Time.time;
        rb = gameObject.GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {

        if(Input.GetKey(KeyCode.Space)){
            rb.AddForce(transform.right *  moveSpeed, ForceMode2D.Impulse);
        }
        if(Time.time > lastUpdateTime + timeBetweenUpdate){
            //lastUpdateTime = Time.time;
            //rb.AddForce(new Vector2(+0.5f  *moveSpeed, -0.8f  *moveSpeed), ForceMode2D.Impulse);
            Transform start = piece.transform.GetChild(0);
            Transform end = piece.transform.GetChild(1);
            float distance = Mathf.Abs(start.position.magnitude - end.position.magnitude);

            float noise = Mathf.PerlinNoise(transform.position.x * 0.01f, 1);
            print(noise);

            GameObject level = Instantiate(piece, new Vector3(transform.position.x + distance + 10,
                                                              noise * scale, transform.position.z),
                                           Quaternion.identity, parent);

        }
    }
}
