using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    [SerializeField] private Animator animator = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Listen to the left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Set up a trigger to start the animation
            animator.SetTrigger("FadeOut");
        }
    }
}
