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
    private bool isGrabbed;
    void Start()
    {

    }

    void Update()
    {
            grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);
            GameObject theObject = grabCheck.collider.gameObject;
            if(grabCheck.collider != null && grabCheck.collider.tag == "Item"){
            if(Input.GetKey(KeyCode.F)){
                isGrabbed = true;
            }
            } else {
                 isGrabbed = false;
            }
            if(isGrabbed == true){
                while(carryItemNumber < 1){
                carryItemNumber = carryItemNumber + 1;
                }
            } else if(grabScript.isGrabbed == false){
                carryItemNumber = 0;
            }
    }
}
