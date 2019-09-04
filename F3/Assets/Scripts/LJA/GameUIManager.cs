using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shot_Click()
    {
        
            // Application.CaptureScreenshot(Application.persistentDataPath + "ScreenShot.png", 0);//过时的方法
            ScreenCapture.CaptureScreenshot(Application.streamingAssetsPath + "/ScreenShot.png", 0);
        
    }

    
}
