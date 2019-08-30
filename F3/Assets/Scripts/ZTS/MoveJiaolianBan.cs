using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJiaolianBan : MonoBehaviour
{
    public float MoveSpeed = 10;
    bool isCanMoveRight = false;
    // Start is called before the first frame update
    void Start()
    {
        isCanMoveRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCanMoveRight)
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);
        }
        else
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * -MoveSpeed);
        }
       
    }
}
