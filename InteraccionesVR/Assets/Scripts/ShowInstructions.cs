using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInstructions : MonoBehaviour
{
    public Canvas prompt;
    public AudioSource audioSource;
    public AudioSource itemCollectedAudio;
    public AudioClip audioClip;

    private bool finished = false;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            int totalItems = GlobalsItems.GetTotalItems();
            int totalCollected = GlobalsItems.GetTotalCollected();

            if (!finished && totalItems == totalCollected)
            {
                itemCollectedAudio.Play();
                audioSource.clip = audioClip;
                audioSource.Play();
                finished = true;
            }

            if (totalItems == totalCollected)
            {
                prompt.GetComponentInChildren<Text>().text = "Felicidades, lograste ayudar a todos!";
            }
            else
            {
                prompt.GetComponentInChildren<Text>().text = 
                "Ayuda a todos a obtener objetos por la playa. " + totalCollected + "/" + totalItems;
            }
            prompt.enabled = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            prompt.enabled = false;
        }
    }
}
