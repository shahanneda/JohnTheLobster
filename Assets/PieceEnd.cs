using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceEnd : MonoBehaviour
{

    public GameObject piece;
    public float scale = 10;
    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        Transform start = piece.transform.GetChild(0);
        Transform end = piece.transform.GetChild(1);
        float distance = Mathf.Abs(start.position.magnitude - end.position.magnitude);

        float noise = Mathf.PerlinNoise(transform.position.x * 0.01f, 1);
        print(noise);

        GameObject level = Instantiate(piece, new Vector3(transform.position.x * distance + 100,
                                                          transform.position.y + noise * scale, transform.position.z),
                                       Quaternion.identity, parent);

    }
}
