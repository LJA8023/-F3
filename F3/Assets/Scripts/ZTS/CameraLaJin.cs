using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLaJin : MonoBehaviour
{

    public Camera camera;

    public float endSize = 0;

    bool isCanLaJin = false;
    // Start is called before the first frame update
    void Start()
    {
        isCanLaJin = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCanLaJin)
        {
            camera.orthographicSize -= Time.deltaTime;
            if (camera.orthographicSize <= endSize)
            {
                isCanLaJin = false;
                camera.orthographicSize = endSize;
            }
        }
       
        
    }
}
