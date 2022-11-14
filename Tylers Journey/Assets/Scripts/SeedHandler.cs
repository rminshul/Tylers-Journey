using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeedHandler : MonoBehaviour
{
    private Animator fadeAnimator = null;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

   IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        fadeAnimator.SetTrigger("FadeOut");
    }
}
