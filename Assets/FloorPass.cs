﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPass : MonoBehaviour
{

    public GameObject levelPrefab;
    public Transform levelSpawnLocation;
    public Transform levelParent;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if( col.gameObject.CompareTag("Player")){
            GameObject newLevelPiece = Instantiate(levelPrefab, levelSpawnLocation.position, Quaternion.identity, levelParent) as GameObject;
        }
    }
}
