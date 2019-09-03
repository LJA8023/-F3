using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batjump : MonoBehaviour
{
    private Rigidbody2D GC;
    // Start is called before the first frame update
    void Start()
    {
        GC = GetComponent<Rigidbody2D>();
        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.transform.parent.Find("Bat").GetComponent<Rigidbody2D>().simulated = true;
        
        gameObject.transform.parent.Find("Bat").GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 40.0f);
        
    }

}
