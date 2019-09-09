using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    public AudioClip UI_push;
    // Start is called before the first frame update
    public void Home_Click()
    {
        AudioSource.PlayClipAtPoint(UI_push, Camera.main.transform.position);
        SceneManager.LoadScene("LJA");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Btn_LCH()
    {
        AudioSource.PlayClipAtPoint(UI_push, Camera.main.transform.position);
        SceneManager.LoadScene("LCH");
    }
    public void Btn_ZTS()
    {
        AudioSource.PlayClipAtPoint(UI_push, Camera.main.transform.position);
        SceneManager.LoadScene("ZTS");
    }
    public void Btn_Lijiaao()
    {
        AudioSource.PlayClipAtPoint(UI_push, Camera.main.transform.position);
        SceneManager.LoadScene("Game");
    }
}
