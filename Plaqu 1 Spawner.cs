using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plaqu1Spawner : MonoBehaviour
{
    [SerializeField] GameObject preFab;
    public float timer = 0;

    void Start()
    {
        spawn();
    }

    void Update()
    {
        if (timer > Random.Range(20, 80))
        {
            spawn();
            timer = 0;
        }
        else
        {
            timer = timer + Time.deltaTime;
        }
    }

    void spawn()
    {
        Instantiate(preFab, new Vector3(transform.position.x, transform.position.y), transform.rotation);
    }
}
