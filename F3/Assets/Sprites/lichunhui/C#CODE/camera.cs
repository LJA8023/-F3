using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform Cat;
    private float distanceX = 3.0f ;
    private float came_y ;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
            if(!cat.Catisdead)
            {
    if(Cat.transform.position.y>=0)
            {
               came_y = Cat.transform.position.y+2;
            }
         else
            {
                came_y = 2.0f;
            }
        transform.position = new Vector3(Cat.position.x + distanceX, came_y, -10);
        }
        
    }
}
