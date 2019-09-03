using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeParent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Car")
        {
            CarMove.isCanMove = true;
            gameObject.transform.parent = collision.gameObject.transform;
        }
    }
}
