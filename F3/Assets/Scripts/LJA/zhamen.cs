using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhamen : MonoBehaviour
{
    public AudioClip open_door;
    public GameObject kaiguan_red;
    public GameObject kaiguan_green;
    public Animator door;
    // Start is called before the first frame update
    void Start()
    {
        kaiguan_red.SetActive(true);
        kaiguan_green.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(open_door, Camera.main.transform.position);
        kaiguan_green.SetActive(true);
          kaiguan_red.SetActive(false);
          door.enabled = true;
       
       
    }
}
