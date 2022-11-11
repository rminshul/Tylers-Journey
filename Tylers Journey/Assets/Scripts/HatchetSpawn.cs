using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatchetSpawn : MonoBehaviour
{
    
    public GameObject hatchetPrefab;
    public float speed = 10.0f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TriggerSwing();
            
        }
      
    }

    void TriggerSwing()
    {
        animator.SetTrigger("isAttacking");
    }
}
