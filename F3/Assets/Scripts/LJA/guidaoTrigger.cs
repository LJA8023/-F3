using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guidaoTrigger : MonoBehaviour
{
    private Rigidbody2D rig = null;
    public GameObject Car;

    // Start is called before the first frame update
    void Start()
    {
        rig = Car.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            rig.AddForce(new Vector2(0, 0));
        }
        

    }
}
    

