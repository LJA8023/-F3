using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuUIControler : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play_Click()
    {
        SceneManager.LoadScene("Game");
    }
    public void Exit_Click()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
