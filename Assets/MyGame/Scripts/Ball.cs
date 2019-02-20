using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D myRigidBody2D;
    private SceneLoader sceneLoader;
    private bool hasStarted = false;

    public float xPush = 2f, yPush = 10f;
    public float randomFactor = 3f;

    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    void Update()
    {
        if (!hasStarted) // geht nur bei start hierhin
        {
            hasStarted = true;
            myRigidBody2D.velocity = new Vector2(xPush, yPush);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // immer bei collision
    {
        Vector2 velocityTweak = new Vector2 // wenn auf true bei collision wird hinzugehfügt
                                 (UnityEngine.Random.Range(-randomFactor, randomFactor),
                                  UnityEngine.Random.Range(-randomFactor, randomFactor));
        if(hasStarted)
        {
            myRigidBody2D.velocity += velocityTweak;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sceneLoader.LoadGameOver();
    }
}