using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeRotation : MonoBehaviour

{
    // boolean value that states whether the object should be rotating or not 
    public bool isStatic = false;

    // Update is called once per frame
    void Update()
    {
        // rotates the object depending on the boolean value
        if(isStatic){
            transform.Rotate(Vector3.right);
        } 
    }

    // activates or deactivates rotation when object is clicked on
    private void OnMouseDown(){
        isStatic = !isStatic;
    }
}
