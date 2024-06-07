using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToolTipController : MonoBehaviour
{
    public static ToolTipController instance;
    public TextMeshProUGUI textMeshComponent;
    // allows only one instance of the tooltip to be on screen 
    private void Awake(){
        if(instance != null && instance!= this){
            Destroy(this.gameObject);
        }
        else{
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // changes position of tooltip to keep it at mouse position
        transform.position = Input.mousePosition;
    }

    // shows tooltip with desired text
    public void displayToolTip(string text){
        gameObject.SetActive(true);
        textMeshComponent.text = text;
    }

    // hides tooltip
    public void HideToolTip(){
        gameObject.SetActive(false);
        textMeshComponent.text = string.Empty;
    }


}
