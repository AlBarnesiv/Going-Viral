using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VaccineSpawner : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    [SerializeField] GameObject up;
    [SerializeField] GameObject down;
    [SerializeField] GameObject left;
    bool upCheck = true;
    bool leftCheck = false;
    bool downCheck = false;
    public float spawnTick = 0;
    public float tickSpeed = 1.0f;
    public float spawnSpeed = 1.0f;
    public float[] upTick = { 1, 4, 7 };
    public float[] midTick = { 2, 5, 8 };
    public float[] downTick = { 3, 6, 9 };

    //void Update(){
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Needle")
        {
            Debug.Log("Needle Enter");
            Tick();
            foreach (float upSpawn in upTick)
            {
                if (InRange(spawnTick, upSpawn))
                {
                    SpawnUp();
                    audioSource.PlayOneShot(audioClip);
                }
            }
            foreach (float leftSpawn in midTick)
            {
                if (InRange(spawnTick, leftSpawn))
                {
                    SpawnLeft();
                    audioSource.PlayOneShot(audioClip);
                }
            }
            foreach (float downSpawn in downTick)
            {
                if (InRange(spawnTick, downSpawn))
                {
                    SpawnDown();
                    audioSource.PlayOneShot(audioClip);
                }
            }
        }
    }
    void Tick()
    {
        spawnTick += tickSpeed * Time.deltaTime * spawnSpeed;
    }

    void SpawnUp()
    {
        if (upCheck)
        {
            Instantiate(up, new Vector3(transform.position.x, transform.position.y), transform.rotation);
            leftCheck = true;
            upCheck = false;
        }
    }

    void SpawnLeft()
    {
        if (leftCheck)
        {
            Instantiate(left, new Vector3(transform.position.x, transform.position.y), transform.rotation);
            downCheck = true;
            leftCheck = false;
        }
    }

    void SpawnDown()
    {
        if (downCheck)
        {
            Instantiate(down, new Vector3(transform.position.x, transform.position.y), transform.rotation);
            upCheck = true;
            downCheck = false;
        }
    }

    bool InRange(float value, float target)
    {
        float epsilon = 0.4f;
        return Mathf.Abs(value - target) < epsilon;
    }
}
