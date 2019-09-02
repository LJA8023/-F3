//猫身上的代码
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    private Animator Cat = null;
    private float dead_li_x = -100.0f;
    private float dead_li_y = 100.0f;
    private bool d = true;
    // Start is called before the first frame update
    void Start()
    {
        Cat = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //猫移动的方法
    private void run()
    {
       
    }
    private void FixedUpdate()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("bianfu")|| collision.gameObject.CompareTag("huoqiu")&&d)
        {
            d = !d;
            Cat.SetTrigger("isdead");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(dead_li_x,dead_li_y));

        }
        if(collision.gameObject.CompareTag("bianfujump"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(120, 300));
        }
    }
}
