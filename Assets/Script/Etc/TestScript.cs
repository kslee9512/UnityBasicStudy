﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TestScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("안녕하세요");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Random.Range(0, 10));
    }
}
