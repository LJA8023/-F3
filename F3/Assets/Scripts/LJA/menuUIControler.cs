using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class menuUIControler : MonoBehaviour
{
    public AudioClip UI_push;
    public Toggle tog_Sound = null;
    public AudioSource myAudio;
    public Animator panel_shezhimianban;
    public GameObject panel_buttons;
    public GameObject panel_handle;
    //public float TimeInterval = 1.0f;
    //private float TimeStart = 0;
    public GameObject panel_credits;
    public GameObject panel_menu;
    bool judge = false;
    //public GameObject panel_menu;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        //TimeStart += Time.deltaTime;
    }
    public void Play_Click()
    {
        SceneManager.LoadScene("Menu");
        AudioSource.PlayClipAtPoint(UI_push, Camera.main.transform.position);
    }
    public void Exit_Click()
    {
        AudioSource.PlayClipAtPoint(UI_push, Camera.main.transform.position);
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void vol(float v)
    {
        myAudio.volume = v;
        tog_Sound.isOn = v == 0 ? true : false;

    }
    public void Settings_Click()
    {
        AudioSource.PlayClipAtPoint(UI_push, Camera.main.transform.position);
        panel_menu.SetActive(false);
        panel_shezhimianban.enabled = true;
        panel_shezhimianban.SetBool("SlideIn", true);
        
    }
    public void panel_exit()
    {
        AudioSource.PlayClipAtPoint(UI_push, Camera.main.transform.position);
        StartCoroutine(Test(1.5f));
    }
        IEnumerator Test(float waittime)
        {
             panel_shezhimianban.SetBool("SlideIn", false);
            yield return new WaitForSeconds(waittime);
            panel_menu.SetActive(true); 
        }
          
        
    
    public void Credits_Click()
    {
        AudioSource.PlayClipAtPoint(UI_push, Camera.main.transform.position);
        panel_buttons.SetActive(false);
        panel_credits.SetActive(true);
    }
    public void handle_Click()
    {
        AudioSource.PlayClipAtPoint(UI_push, Camera.main.transform.position);
        panel_handle.SetActive(!judge);
        judge = !judge;
    }
    public void creditsExit_Click()
    {
        AudioSource.PlayClipAtPoint(UI_push, Camera.main.transform.position);
        panel_credits.SetActive(false);
        panel_buttons.SetActive(true);
       
    }
}
