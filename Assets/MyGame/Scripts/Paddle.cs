using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour 
{ //ermöglicht, skripte als komponenten hnzuzufügen

    public float speed;
    public float minPosLeft;
    public float maxPosRight;
    public float padding;
   
	// Use this for initialization
	void Start() 
	{
        minPosLeft = -5.448667f;
        maxPosRight = 5.448667f;
        padding = 1.218f;

        SetupMoveBoundaries();
	}

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

// Steuerung des Players (Arrowkeys bzw. a und d für links und rechts)