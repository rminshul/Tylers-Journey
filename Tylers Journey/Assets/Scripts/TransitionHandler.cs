using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionHandler : MonoBehaviour
{
    [SerializeField] private string nextScene = "";
    [SerializeField] private bool disableFadeInAnimation = false;

    // Start is called before the first frame update
    void Start()
    {
        if (disableFadeInAnimation)
        {
            // Move fade-in animation to the end
            Animator animator = gameObject.GetComponent<Animator>();
            animator.Play("FadeIn", 0, 5);
        }
    }

    void FadeOutFinished()
    {
        // Load of the next scene
        SceneManager.LoadScene(nextScene);
    }
}
