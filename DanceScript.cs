using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceScript : MonoBehaviour
{
    Animation dance;
    public GameObject item;
    public GrabScript GS;
    void Start()
    {
        dance = GetComponent<Animation>();     
    }

    void Update()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();

        if(GS.isGrabbed == true){
            dance.Stop("DanceItem");
            transform.localRotation = Quaternion.Euler(new Vector3(0,0,0));
        } else if(GS.isGrabbed == false){
            dance.Play("DanceItem");
        }
        if(GS.enabled == true){
            dance.Play("DanceItem");
        } else if(GS.enabled == false){
            dance.Stop("DanceItem");
            transform.localRotation = Quaternion.Euler(new Vector3(0,0,0));
        }
    }
}