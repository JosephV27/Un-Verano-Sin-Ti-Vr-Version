using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public Canvas prompt;
    public AudioSource audioSource;
    public AudioSource itemCollectedAudio;
    public AudioClip newAudioClip;
    public int itemId;
    public string newText;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == GlobalsItems.GetItemTag(itemId) && !GlobalsItems.IsItemCollected(itemId))
        {
            itemCollectedAudio.Play();
            GlobalsItems.CollectItem(itemId);
            prompt.GetComponentInChildren<Text>().text = newText;
            audioSource.clip = newAudioClip;
            audioSource.Play();
        }
        Debug.Log("Total collected items: " + GlobalsItems.GetTotalCollected());
    }
}
