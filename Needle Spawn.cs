using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleSpawn : MonoBehaviour
{
    Score score;
    [SerializeField] GameObject scoreKeeper;
    [SerializeField] GameObject preFab;
    public int[] scoreRange = { 25, 50, 75, 100 };
    public int[] spawnReset = { 26, 51, 76, 101 };
    private bool spawnCheck = false;

    void Awake()
    {
        score = scoreKeeper.GetComponent<Score>();
    }

    void Update()
    {
        if (score != null)
        {
            int currentScore = score.playerScore;
            foreach (int specialScore in scoreRange)
            {
                if (currentScore == specialScore && !spawnCheck)
                {
                    Spawn();
                    spawnCheck = true;
                }
            }
            foreach (int resetScore in spawnReset)
            {
                if (currentScore == resetScore)
                {
                    spawnCheck = false;
                }
            }
        }
    }

    void Spawn()
    {
        Instantiate(preFab, new Vector3(transform.position.x, transform.position.y), transform.rotation);
    }
}

