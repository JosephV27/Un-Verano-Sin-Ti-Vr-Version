using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPrompt : MonoBehaviour
{
    public Canvas Prompt;
    
    void OnTriggerEnter(Collider ObjectEntering) {
        Debug.Log(ObjectEntering.gameObject.name);
        Debug.Log(ObjectEntering.tag);
        if(ObjectEntering.tag == "Player") {
            Prompt.enabled = true;
        }
    }
    void onTriggerExit(Collider ObjectLeaving) {
        if(ObjectLeaving.tag == "Player") {
            Prompt.enabled = false;
        }
    }
}
