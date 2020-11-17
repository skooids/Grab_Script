using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceScript : MonoBehaviour
{
    Animation dance;
    public GameObject item;
    public GrabScript GS;
    public ItemsCount IC;
    void Start()
    {
        dance = GetComponent<Animation>();     
    }

    void Update()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();

        if(IC.isGrabbed == true){
            dance.Stop("DanceItem");
            transform.localRotation = Quaternion.Euler(new Vector3(0,0,0));
        } else if(IC.isGrabbed == false){
            dance.Play("DanceItem");
        }
        if(IC.enabled == true){
            dance.Play("DanceItem");
        } else if(IC.enabled == false){
            dance.Stop("DanceItem");
            transform.localRotation = Quaternion.Euler(new Vector3(0,0,0));
        }
    }
}
