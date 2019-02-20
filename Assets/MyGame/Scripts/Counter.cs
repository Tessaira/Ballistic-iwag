using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour 
{
    private int hitCounter = 0;
    [SerializeField] Text counterText;
	
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            hitCounter++;
            counterText.text = hitCounter.ToString();
        } 
    }
}