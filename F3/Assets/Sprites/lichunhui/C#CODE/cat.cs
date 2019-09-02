//猫身上的代码
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    private Animator Cat = null;
    private float dead_li_x = -100.0f;
    private float dead_li_y = 100.0f;
    private float y;//猫每次接触板子会记录一次当前y坐标
    private float ymax = 3.0f;//猫能跳跃的最大高度
    private bool jump;

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
        if(Input.GetButton("Fire1"))
        {
            if (transform.position.y >= y + ymax)
            {
                jump = false;
            }
            else if(jump == true)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 35));
            }
        }
        

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bianfu")|| collision.gameObject.CompareTag("huoqiu"))
        {
             Cat.SetTrigger("isdead");
             GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
             GetComponent<Rigidbody2D>().AddForce(new Vector2(dead_li_x, dead_li_y));
             Cat.GetComponent<Collider2D>().enabled = false;
        }
        
        if(collision.gameObject.CompareTag("bianfujump"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(120, 300));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        y = transform.position.y;
        jump = true;

    }
}
