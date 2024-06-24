using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vein3 : MonoBehaviour
{
    [SerializeField] GameObject preFab;
    public float timer = 0;
    public float heightOffSet = 2;

    void Start()
    {
        spawn();
    }

    void Update()
    {
        if (timer > Random.Range(2, 5))
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
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;
        Instantiate(preFab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
