/*  This script controls the speed of the veins in the background.*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpeed : MonoBehaviour
{
    [SerializeField] int Speed = 1;
    [SerializeField] Rigidbody2D rigidBody;

    void Update()
    {
        backgroundSpeed();
    }

    void backgroundSpeed()
    {
        rigidBody.velocity = Vector2.left * Speed;
    }
}
