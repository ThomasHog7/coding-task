using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTip : MonoBehaviour
{
    public string message;




    // activated when mouse is hovering over object 
    private void OnMouseEnter(){
        
        ToolTipController.instance.displayToolTip(message);

    }

    // deactivates tooltip when mouse is not hovering over gameobject
    private void OnMouseExit(){
        ToolTipController.instance.HideToolTip();
    }



}
