using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airjump : MonoBehaviour
{     private Vector3 ab;
    // Start is called before the first frame update
    private bool airjumpBig = false;
    private int a = 0;
    void Start()
    {
        ab = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        /*if(airjumpBig)
        {
            a++;
                if(a == 5)
            {
                airjumpBig = false;
            }
                if(a%2 == 0)
            {
                GetComponent<Transform>().localScale = new Vector3(0.81f, 0.75f, 1);
            }
                else
            {
                GetComponent<Transform>().localScale = new Vector3(0.75f, 0.75f, 1);
            }
        }*/
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       /* airjumpBig = true;
        GetComponent<Transform>().localScale = new Vector3(0.81f, 0.75f, 1);*/
    }
}
