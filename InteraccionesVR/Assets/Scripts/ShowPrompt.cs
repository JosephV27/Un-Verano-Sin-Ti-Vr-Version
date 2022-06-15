using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPrompt : MonoBehaviour
{
    public Canvas Prompt;
    
    void OnTriggerStay(Collider ObjectEntering) {
        if(ObjectEntering.tag == "Player") {
            Debug.Log("PLAYER ENTERING");
            Prompt.enabled = true;
        }
    }

    void OnTriggerExit(Collider ObjectLeaving) {
        if(ObjectLeaving.tag == "Player") {
            Debug.Log("PLAYER LEAVING");
            Prompt.enabled = false;
        }
    }
}
