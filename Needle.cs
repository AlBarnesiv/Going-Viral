using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AdaptivePerformance.VisualScripting;
using UnityEngine.UIElements;

public class Needle : MonoBehaviour
{
    [SerializeField] GameObject needleStartPoint;
    [SerializeField] GameObject needleEndPoint;
    public Transform startPoint;
    public Transform endPoint;
    public float speed = 2.0f;
    public float pauseDuration = 9.0f;
    private Transform target;

    void Start()
    {
        needleStartPoint = GameObject.Find("Needle Start Point");
        needleEndPoint = GameObject.Find("Needle End Point");
        startPoint = needleStartPoint.GetComponent<Transform>();
        endPoint = needleEndPoint.GetComponent<Transform>();
        target = endPoint;
    }

    void Update()
    {
        MoveToTarget();
        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            Invoke("SwitchTarget", pauseDuration);
        }
        if (transform.position.y == 11)
        {
            Delete();
        }
    }

    void MoveToTarget()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    void SwitchTarget()
    {
        target = startPoint;
    }

    void Delete()
    {
        Destroy(gameObject);
    }
}
