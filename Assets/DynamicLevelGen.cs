using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicLevelGen : MonoBehaviour
{
    public GameObject piece;

    public float scale = 10;

    private void Start()
    {
        Transform start = piece.transform.GetChild(0);
        Transform end = piece.transform.GetChild(1);
        float distance = Mathf.Abs(start.position.magnitude - end.position.magnitude);



        for (int i = 0; i < 100; i++){
            float test = Random.Range(-10, 10);
            float noise = Mathf.PerlinNoise(i*0.01f, 1);
            print(noise);

            GameObject level = Instantiate(piece, new Vector3(transform.position.x + i*distance, transform.position.y + noise*scale, transform.position.z), Quaternion.identity, transform);
        }
    }
}
