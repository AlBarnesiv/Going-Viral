using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpeedCurve : MonoBehaviour
{

    Score score;
    ForegroundSpeed redBloodCellSpeed;
    ForegroundSpeed whiteBloodCellSpeed;
    Spawner redBloodCellSpawn;
    Spawner whiteBloodCellSpawn;
    bool baseSpawn = true;
    bool tierOneSpawn = false;
    bool tierTwoSpawn = false;
    bool tierThreeSpawn = false;
    bool tierFourSpawn = false;
    bool tierFiveSpawn = false;
    int basicRedBloodCellSpawn = 0;
    int basicWhiteBloodCellSpawn = 0;
    int tierOneRedBloodCellSpawn = 10;
    int tierOneWhiteBloodCellSpawn = 10;
    int tierTwoRedBloodCellSpawn = 10;
    int tierTwoWhiteBloodCellSpawn = 10;
    int tierThreeRedBloodCellSpawn = 10;
    int tierThreeWhiteBloodCellSpawn = 10;
    int tierFourRedBloodCellSpawn = 10;
    int tierFourWhiteBloodCellSpawn = 10;
    int tierFiveRedBloodCellSpawn = 10;
    int tierFiveWhiteBloodCellSpawn = 10;
    [SerializeField] GameObject scoreKeeper;
    [SerializeField] GameObject speedRbc;
    [SerializeField] GameObject speedWbc;
    [SerializeField] GameObject spawnRbc;
    [SerializeField] GameObject spawnWbc;

    void Awake()
    {
        score = scoreKeeper.GetComponent<Score>();
        redBloodCellSpeed = speedRbc.GetComponent<ForegroundSpeed>();
        whiteBloodCellSpeed = speedWbc.GetComponent<ForegroundSpeed>();
        redBloodCellSpawn = spawnRbc.GetComponent<Spawner>();
        whiteBloodCellSpawn = spawnWbc.GetComponent<Spawner>();
    }

    public void Update()
    {
        // Base Spawn
        if (baseSpawn == true)
        {
            BasicSpawnLoopRBC();
            BasicSpawnLoopWBC();
            redBloodCellSpeed.foregroundSpeed = 2;
            whiteBloodCellSpeed.foregroundSpeed = 2;

            if (redBloodCellSpawn.timer > basicRedBloodCellSpawn)
            {
                redBloodCellSpawn.spawn();
                redBloodCellSpawn.timer = 0;
                BasicSpawnLoopRBC();
            }
            else
            {
                redBloodCellSpawn.timer = redBloodCellSpawn.timer + Time.deltaTime;
                BasicSpawnLoopRBC();
            }
            if (whiteBloodCellSpawn.timer > basicWhiteBloodCellSpawn)
            {
                whiteBloodCellSpawn.spawn();
                whiteBloodCellSpawn.timer = 0;
                BasicSpawnLoopWBC();
            }
            else
            {
                whiteBloodCellSpawn.timer = whiteBloodCellSpawn.timer + Time.deltaTime;
                BasicSpawnLoopWBC();
            }
        }

        // Tier One Spawn
        if (score.playerScore >= 10)
        {
            baseSpawn = false;
            tierOneSpawn = true;

            if (tierOneSpawn == true)
            {
                TierOneSpawnLoopRBC();
                TierOneSpawnLoopWBC();
                redBloodCellSpeed.foregroundSpeed = 3;
                whiteBloodCellSpeed.foregroundSpeed = 3;

                if (redBloodCellSpawn.timer > tierOneRedBloodCellSpawn)
                {
                    redBloodCellSpawn.spawn();
                    redBloodCellSpawn.timer = 0;
                    TierOneSpawnLoopRBC();
                }
                else
                {
                    redBloodCellSpawn.timer = redBloodCellSpawn.timer + Time.deltaTime;
                    TierOneSpawnLoopRBC();
                }
                if (whiteBloodCellSpawn.timer > tierOneWhiteBloodCellSpawn)
                {
                    whiteBloodCellSpawn.spawn();
                    whiteBloodCellSpawn.timer = 0;
                    TierOneSpawnLoopWBC();
                }
                else
                {
                    whiteBloodCellSpawn.timer = whiteBloodCellSpawn.timer + Time.deltaTime;
                    TierOneSpawnLoopWBC();
                }
            }
        }

        // Tier Two Spawn
        if (score.playerScore >= 25)
        {
            tierOneSpawn = false;
            tierTwoSpawn = true;

            if (tierTwoSpawn == true)
            {
                TierTwoSpawnLoopRBC();
                TierTwoSpawnLoopWBC();
                redBloodCellSpeed.foregroundSpeed = 4;
                whiteBloodCellSpeed.foregroundSpeed = 4;

                if (redBloodCellSpawn.timer > tierTwoRedBloodCellSpawn)
                {
                    redBloodCellSpawn.spawn();
                    redBloodCellSpawn.timer = 0;
                    TierTwoSpawnLoopRBC();
                }
                else
                {
                    redBloodCellSpawn.timer = redBloodCellSpawn.timer + Time.deltaTime;
                    TierTwoSpawnLoopRBC();
                }
                if (whiteBloodCellSpawn.timer > tierOneWhiteBloodCellSpawn)
                {
                    whiteBloodCellSpawn.spawn();
                    whiteBloodCellSpawn.timer = 0;
                    TierTwoSpawnLoopWBC();
                }
                else
                {
                    whiteBloodCellSpawn.timer = whiteBloodCellSpawn.timer + Time.deltaTime;
                    TierTwoSpawnLoopWBC();
                }
            }
        }

        // Tier Three Spawn
        if (score.playerScore >= 50)
        {
            tierTwoSpawn = false;
            tierThreeSpawn = true;

            if (tierThreeSpawn == true)
            {
                TierThreeSpawnLoopRBC();
                TierThreeSpawnLoopWBC();
                redBloodCellSpeed.foregroundSpeed = 5;
                whiteBloodCellSpeed.foregroundSpeed = 5;

                if (redBloodCellSpawn.timer > tierThreeRedBloodCellSpawn)
                {
                    redBloodCellSpawn.spawn();
                    redBloodCellSpawn.timer = 0;
                    TierThreeSpawnLoopRBC();
                }
                else
                {
                    redBloodCellSpawn.timer = redBloodCellSpawn.timer + Time.deltaTime;
                    TierThreeSpawnLoopRBC();
                }
                if (whiteBloodCellSpawn.timer > tierOneWhiteBloodCellSpawn)
                {
                    whiteBloodCellSpawn.spawn();
                    whiteBloodCellSpawn.timer = 0;
                    TierThreeSpawnLoopWBC();
                }
                else
                {
                    whiteBloodCellSpawn.timer = whiteBloodCellSpawn.timer + Time.deltaTime;
                    TierThreeSpawnLoopWBC();
                }
            }
        }

        // Tier Four Spawn
        if (score.playerScore >= 75)
        {
            tierThreeSpawn = false;
            tierFourSpawn = true;

            if (tierFourSpawn == true)
            {
                TierFourSpawnLoopRBC();
                TierFourSpawnLoopWBC();
                redBloodCellSpeed.foregroundSpeed = 6;
                whiteBloodCellSpeed.foregroundSpeed = 6;

                if (redBloodCellSpawn.timer > tierFourRedBloodCellSpawn)
                {
                    redBloodCellSpawn.spawn();
                    redBloodCellSpawn.timer = 0;
                    TierFourSpawnLoopRBC();
                }
                else
                {
                    redBloodCellSpawn.timer = redBloodCellSpawn.timer + Time.deltaTime;
                    TierFourSpawnLoopRBC();
                }
                if (whiteBloodCellSpawn.timer > tierOneWhiteBloodCellSpawn)
                {
                    whiteBloodCellSpawn.spawn();
                    whiteBloodCellSpawn.timer = 0;
                    TierFourSpawnLoopWBC();
                }
                else
                {
                    whiteBloodCellSpawn.timer = whiteBloodCellSpawn.timer + Time.deltaTime;
                    TierFourSpawnLoopWBC();
                }
            }
        }

        // Tier Five Spawn
        if (score.playerScore >= 100)
        {
            tierFourSpawn = false;
            tierFiveSpawn = true;

            if (tierFiveSpawn == true)
            {
                TierFiveSpawnLoopRBC();
                TierFiveSpawnLoopWBC();
                redBloodCellSpeed.foregroundSpeed = 7;
                whiteBloodCellSpeed.foregroundSpeed = 7;

                if (redBloodCellSpawn.timer > tierFiveRedBloodCellSpawn)
                {
                    redBloodCellSpawn.spawn();
                    redBloodCellSpawn.timer = 0;
                    TierFiveSpawnLoopRBC();
                }
                else
                {
                    redBloodCellSpawn.timer = redBloodCellSpawn.timer + Time.deltaTime;
                    TierFiveSpawnLoopRBC();
                }
                if (whiteBloodCellSpawn.timer > tierOneWhiteBloodCellSpawn)
                {
                    whiteBloodCellSpawn.spawn();
                    whiteBloodCellSpawn.timer = 0;
                    TierFiveSpawnLoopWBC();
                }
                else
                {
                    whiteBloodCellSpawn.timer = whiteBloodCellSpawn.timer + Time.deltaTime;
                    TierFiveSpawnLoopWBC();
                }
            }
        }
    }

    // Spawn Chance Randomizers 
    void BasicSpawnLoopRBC()
    {
        basicRedBloodCellSpawn = Random.Range(3, 8);
    }
    void BasicSpawnLoopWBC()
    {
        basicWhiteBloodCellSpawn = Random.Range(4, 8);
    }
    void TierOneSpawnLoopRBC()
    {
        tierOneRedBloodCellSpawn = Random.Range(3, 6);
    }
    void TierOneSpawnLoopWBC()
    {
        tierOneWhiteBloodCellSpawn = Random.Range(3, 6);
    }
    void TierTwoSpawnLoopRBC()
    {
        tierTwoRedBloodCellSpawn = Random.Range(3, 5);
    }
    void TierTwoSpawnLoopWBC()
    {
        tierTwoWhiteBloodCellSpawn = Random.Range(3, 5);
    }
    void TierThreeSpawnLoopRBC()
    {
        tierThreeRedBloodCellSpawn = Random.Range(2, 5);
    }
    void TierThreeSpawnLoopWBC()
    {
        tierThreeWhiteBloodCellSpawn = Random.Range(2, 5);
    }
    void TierFourSpawnLoopRBC()
    {
        tierFourRedBloodCellSpawn = Random.Range(1, 5);
    }
    void TierFourSpawnLoopWBC()
    {
        tierFourWhiteBloodCellSpawn = Random.Range(1, 5);
    }
    void TierFiveSpawnLoopRBC()
    {
        tierFiveRedBloodCellSpawn = Random.Range(1, 3);
    }
    void TierFiveSpawnLoopWBC()
    {
        tierFiveWhiteBloodCellSpawn = Random.Range(1, 3);
    }

}
