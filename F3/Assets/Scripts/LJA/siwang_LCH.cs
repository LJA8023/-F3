using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class siwang_LCH : MonoBehaviour
{
    public AudioClip drop_water;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(drop_water, Camera.main.transform.position);
            StartCoroutine(Test(0.8f));
        }

        IEnumerator Test(float waittime)
        {

            yield return new WaitForSeconds(waittime);
            eatDiamond.Count = 0;
            Score.text = eatDiamond.Count.ToString();
            cat.Catisdead = false;
            SceneManager.LoadScene("LCH");
            Time.timeScale = 1;
        }
    }
}
