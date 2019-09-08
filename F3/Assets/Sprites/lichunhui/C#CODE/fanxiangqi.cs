using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanxiangqi : MonoBehaviour
{
    public SpriteRenderer car;
    public SpriteRenderer cat;
    public Animator well1;
    public Animator well2;
    public GameObject catgo;
    public GameObject cargo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            car.flipX = true;
            cat.flipX = true;
        catgo.GetComponent<cat>().addli = new Vector2(-catgo.GetComponent<cat>().addli.x, catgo.GetComponent<cat>().addli.y);
        cargo.GetComponent<carli>().Speed = -cargo.GetComponent<carli>().Speed;
    }
}
