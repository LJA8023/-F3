﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public static bool isCanMove = false;
    public float MoveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCanMove)
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);
        }
       
    }
}
