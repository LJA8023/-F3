using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tantiaoqi : MonoBehaviour
{
    public iTween.EaseType type;
    public float tanspeed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        name = gameObject.GetComponent<iTweenPath>().pathName;
    }


// Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag("Player"))
        {
           //collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Destroy(gameObject.GetComponent<Collider2D>());
            Hashtable args = new Hashtable();
            args.Add("speed", tanspeed);
            args.Add("path", iTweenPath.GetPath("path"));
            args.Add("easeType", type);
            iTween.MoveTo(collision.gameObject, args);
        }
    }
}
