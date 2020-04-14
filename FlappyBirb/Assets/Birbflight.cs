﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birbflight : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
    
        if(Input.GetMouseButtonDown(0)){
            //jump
            rigidbody.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        gameManager.GameOver();
    }
}
