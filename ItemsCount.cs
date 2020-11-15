using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsCount : MonoBehaviour
{
    public GrabScript grabScript;
    public Transform grabDetect; 
    public Transform boxHolder;
    public float rayDist;
    public int carryItemNumber;
    private RaycastHit2D grabCheck;
    void Start()
    {

    }

    void Update()
    {
            grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);
            GameObject theObject = grabCheck.collider.gameObject;
            if(grabCheck.collider != null && grabCheck.collider.tag == "Item"){
            if(Input.GetKey(KeyCode.F)){
                grabScript.isGrabbed = true;
                grabScript.enabled = false; 
            }
            } else {
                 grabScript.isGrabbed = false;
                 grabScript.enabled = true;
            }
            if(grabScript.isGrabbed == true){
                while(carryItemNumber < 1){
                carryItemNumber = carryItemNumber + 1;
                }
            } else if(grabScript.isGrabbed == false){
                carryItemNumber = 0;
            }
            if(carryItemNumber > 0){
                grabScript.enabled = false;
            } else if(carryItemNumber == 0){
                 grabScript.enabled = true;
            }
    }
}