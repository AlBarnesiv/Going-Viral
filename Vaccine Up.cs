using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaccineUp : MonoBehaviour
{
    public float speed = 6f;
    bool moveUp = true;

    void Update()
    {
        MoveLeft();
        if (moveUp == true)
        {
            MoveUp();
        }
    }

    void MoveUp()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (transform.position.y == 3.8)
        {
            moveUp = false;
        }
    }

    void MoveLeft()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
