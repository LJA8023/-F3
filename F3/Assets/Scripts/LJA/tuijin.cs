using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuijin : MonoBehaviour
{
    public iTween.EaseType type;
    public Animator tui;
    public GameObject Cat;
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
         tui.enabled = true;
       
        Hashtable args = new Hashtable();
        args.Add("speed", 10.0f);
        args.Add("path", iTweenPath.GetPath("MyPath"));
        args.Add("easeType", type);
        iTween.MoveTo(Cat, args);
    }


}
