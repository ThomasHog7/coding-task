using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScale : MonoBehaviour
{
    private Vector3 OriginalObjectScale;
    private Vector3 OriginalPosition;
    public GameObject object1;
    public GameObject object2;
    private changeColour object1Script;
    private changeRotation object2Script;

    public float scaleSpeed ;
    private bool scaleUp = false;
    private bool scaleDown = false;

    // Start is called before the first frame update
    void Start()
    {
        // gets the objects original scale
        OriginalObjectScale = transform.localScale;
        // gets the objects original position 
        OriginalPosition = transform.position;

        // gets the scripts controlling rotation and colour from other two objects
        object1Script = object1.GetComponent<changeColour>();
        object2Script = object2.GetComponent<changeRotation>();  
    }

    void Update(){
        if(scaleUp){
            // checks whether the scale of the object is double the original size
            if(transform.localScale !=  new Vector3(OriginalObjectScale.x * 2, OriginalObjectScale.y * 2, OriginalObjectScale.z * 2)){
                // adds the scale speed to current scale 
                transform.localScale = new Vector3(transform.localScale.x + scaleSpeed, transform.localScale.y + scaleSpeed, transform.localScale.z+ scaleSpeed);
            }
            // stops scaling up if it double the original scale 
            else{
                scaleUp = false;
            }
        }
        else if(scaleDown){
            // checks whether the scale of the object is the same as the orginal scale
            if(transform.localScale != OriginalObjectScale){
                transform.localScale = new Vector3(transform.localScale.x - scaleSpeed, transform.localScale.y - scaleSpeed,transform.localScale.z - scaleSpeed);
            }
            else{
                 // stops scaling down if it is at the original scale
                scaleDown = false;
            }

        }
    }

    private void OnMouseDown(){
        // changes bool value scale down if the objects  current scale is double the original scale
        if(transform.localScale ==  new Vector3(OriginalObjectScale.x * 2, OriginalObjectScale.y * 2, OriginalObjectScale.z * 2)){
            scaleDown = true;
        }

        // changes bool value scale up if the objects  current scale is the original scale
        // also checks whether the first objects colour is green and second object is not rotating
        else if((transform.localScale == OriginalObjectScale)&&((object1Script.material.GetColor("_Color")==Color.green)&&(!object2Script.isStatic))){
            scaleUp = true;
         
        }



    }
}
