using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;

    //create variable rb
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        
       float move = Input.GetAxis("Horizontal"); //a or left = -1 d or right = 1
       //Vector2 movement = new Vector2(move * speed, 0);
       //rb.AddForce(movement);
       rb.velocity = new Vector2(speed * move, rb.velocity.y);
        
    
    }
}

// Steuerung des Players (Arrowkeys für links und rechts)