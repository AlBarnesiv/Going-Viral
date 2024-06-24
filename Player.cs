using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Rigidbody2D rigidBody;
    public float playerSpeed = 3;
    bool slow = false;
    Score score;
    [SerializeField] GameObject scoreKeeper;

    void Awake()
    {
        score = scoreKeeper.GetComponent<Score>();
    }


    void Update()
    {
        // Slow bool for plaque
        if (slow == true)
        {
            playerSpeed = 1;
        }
        else
        {
            playerSpeed = 3;
        }

        // PC controls
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            rigidBody.velocity = Vector2.right * playerSpeed; // Right
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            rigidBody.velocity = Vector2.left * playerSpeed; // Left
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            rigidBody.velocity = Vector2.up * playerSpeed; // Up
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            rigidBody.velocity = Vector2.down * playerSpeed; // Down
        }

        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            rigidBody.velocity = Vector2.right * playerSpeed; // Right
        }

        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            rigidBody.velocity = Vector2.left * playerSpeed; // Left
        }

        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            rigidBody.velocity = Vector2.up * playerSpeed; // Up
        }

        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            rigidBody.velocity = Vector2.down * playerSpeed; // Down
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plaque")
        {
            slow = true;
        }

        if (collision.gameObject.tag == "RBC")
        {
            // Debug.Log("Score");
            score.addScore();
        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plaque")
        {
            // Debug.Log("Faster");
            slow = false;
        }
    }

}
