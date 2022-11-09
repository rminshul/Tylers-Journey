using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    public Canvas canvas;
    public TextMesh health;
    public float lives = 5.0f;
    public TextMesh score;
    public float points = 100.0f;
    public GameObject enemy;
    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        FirstPersonMovement FPMove = GetComponent<FirstPersonMovement>();
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void LivesLost(object enemy, object player, TextMesh health)
    {
        if (enemy.transform.position >= player.transform.position)
        {
            lives = lives - 1;
            canvas.Update(health);
        }
    }

    public void UpdateScore(float points, TextMesh score)
    {

    }
}