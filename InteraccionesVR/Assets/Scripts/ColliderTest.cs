using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started");
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!Globals.isCollided)
        {
            Debug.Log("Collision detected " + collision.gameObject.layer);
            Globals.isCollided = true;
        }
    }
}
