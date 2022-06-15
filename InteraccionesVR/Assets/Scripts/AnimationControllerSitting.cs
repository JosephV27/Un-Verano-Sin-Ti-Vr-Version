using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerSitting : MonoBehaviour
{
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        // Get the Animator component
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isSitting", true);
    }
}
