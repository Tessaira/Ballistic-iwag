using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //required to switch between Scenes

public class SceneLoader : MonoBehaviour {


    public void PlayBtn()
    {
        // Load Main Level using earlier defined SceneManagement collection
        SceneManager.LoadScene("Main");

    }


    [SerializeField] private string loadLevel;

    //look for other collider
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // load GameOver level
              SceneManager.LoadScene(loadLevel);
        }
    }
    


    public void RetryBtn()
    {
        // Load Main level; is its own button in case I want to add scores later on
        SceneManager.LoadScene("Main");

    }

}

// Lädt die neuen Szenen, wenn Game over ist, man den 'go again' Button klickt, oder das Spiel gestartet wird.
