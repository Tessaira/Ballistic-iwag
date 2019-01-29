using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour { //ermöglicht, skripte als komponenten hnzuzufügen

    public float speed;
    public float minPosLeft;
    public float maxPosRight;
    public float padding;
   

	// Use this for initialization
	void Start () {
        //rb = GetComponent<Rigidbody2D>();
        minPosLeft = -5.448667f;
        maxPosRight = 5.448667f;
        padding = 1.218f;

        SetupMoveBoundaries();
	}



    /* void FixedUpdate()
     {

        float move = Input.GetAxis("Horizontal"); //a or left = -1 d or right = 1
        //Vector2 movement = new Vector2(move * speed, 0);
        //rb.AddForce(movement);
        rb.velocity = new Vector2(speed * move, rb.velocity.y);
         Debug.Log(speed * move);  

     } */
    private void Update()
    {
        Move();   
    }
    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, minPosLeft, maxPosRight);

        transform.position = new Vector2(newPosX, transform.position.y);
    }

    private void SetupMoveBoundaries()
    {
        Camera gameCamera = Camera.main;
        minPosLeft = gameCamera.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).x + padding;
        maxPosRight = gameCamera.ViewportToWorldPoint(new Vector3(1f, 0f, 0f)).x - padding;
    }
}

// Steuerung des Players (Arrowkeys für links und rechts)