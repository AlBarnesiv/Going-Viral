using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForegroundSpeed : MonoBehaviour
{

    public int foregroundSpeed = 2;
    [SerializeField] Rigidbody2D rigidBody;

    public void Update()
    {
        rigidBody.velocity = Vector2.left * foregroundSpeed;
    }
}
