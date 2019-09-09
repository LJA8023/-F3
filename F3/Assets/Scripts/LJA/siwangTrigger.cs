using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class siwangTrigger : MonoBehaviour
{
    public AudioClip drop_water;
    
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
       SceneManager.LoadScene("Game");
    }        
    }
  
}
