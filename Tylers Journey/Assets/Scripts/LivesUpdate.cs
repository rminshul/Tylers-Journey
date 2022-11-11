using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesUpdate : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public int lives;
    public GameObject enemy;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<TextMeshProUGUI>();
        lives = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //if (enemy.transform.position >= player.transform.position)
        {
            healthText.text = lives.ToString();
            lives = lives - 1;
        }
        
    }
}
