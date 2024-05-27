using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public bool isDead;
    
    public float velocity = 1f;
    public Rigidbody2D rigidbody2D;

    public GameManager managerGame;

    public GameObject DeathScreen;

    public GameObject StartScreen;

    private void Start()
    {
        
        Time.timeScale = 1;
    }

    void Update()
    {
        //Tıklama
        if (Input.GetMouseButtonDown(0)) //Left Mobile built alındığında mouse sol click ekrana dokunma(touch) olarak algılanır
        {
            //Kuşu sıçratma
            rigidbody2D.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Score Area")
        {
            managerGame.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeadArea")
        {
            isDead = true;
            Time.timeScale = 0;
            
            DeathScreen.SetActive(true);
            
        }
    }
}
