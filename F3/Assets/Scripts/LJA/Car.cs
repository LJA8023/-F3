using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private Rigidbody2D rig = null;
    public float Speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        rig=gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        rig.velocity = new Vector2(Speed, rig.velocity.y);
    }
}
