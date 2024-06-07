using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColour : MonoBehaviour
{
    public Material material;
    //Start is called before the first frame update
    void Start()
    {
        // gets the material of the object and sets the colour to blue
        material  =GetComponent<Renderer>().material;
        material.SetColor("_Color", Color.blue);
    }

    // activates when object is clicked on 
    private void OnMouseDown(){
        // changes colour to blue or green depending on it current colour
        if (material.GetColor("_Color")==Color.blue){
            material.SetColor("_Color", Color.green);
        }
        else if (material.GetColor("_Color")==Color.green){
            material.SetColor("_Color", Color.blue);
        }
    }
}
