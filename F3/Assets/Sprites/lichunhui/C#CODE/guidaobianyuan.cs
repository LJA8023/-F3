﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guidaobianyuan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            if(collision.gameObject.GetComponent<Rigidbody2D>())
            {
                collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            }
            Destroy(collision.gameObject.GetComponent<Collider2D>());
            Destroy(collision.gameObject.GetComponent<carli>());
        }

    }

}

