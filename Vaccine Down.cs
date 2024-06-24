using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaccineDown : MonoBehaviour
{
    public float speed = 6f;
    bool moveUp = true;

    void Update()
    {
        MoveLeft();
        if (moveUp == true)
        {
            MoveDown();
        }
    }

    void MoveDown()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y == -4)
        {
            moveUp = false;
        }
    }

    void MoveLeft()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
