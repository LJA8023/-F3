using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class menuUIControler : MonoBehaviour
{
    
    public Toggle tog_Sound = null;
    public AudioSource myAudio;
    public Animator panel_shezhimianban;
    
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
        SceneManager.LoadScene("Menu");
    }
    public void Exit_Click()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void vol(float v)
    {
        myAudio.volume = v;
        tog_Sound.isOn = v == 0 ? true : false;
    }
    public void Settings_Click()
    {
        GameObject.FindGameObjectWithTag("panel_menu").SetActive(false);
        panel_shezhimianban.enabled = true;
        panel_shezhimianban.SetBool("SlideIn", true);
    }
    public void exit_Click()
    {
       // GameObject.FindGameObjectWithTag("panel_menu").SetActive(true);
        panel_shezhimianban.SetBool("SlideIn", false);
    }
}
