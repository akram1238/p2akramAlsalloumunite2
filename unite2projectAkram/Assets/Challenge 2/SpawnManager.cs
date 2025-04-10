using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnLimitXLeft = -22.0f;
    private float spawnLimitXRight = 7.0f;
    private float spawnPosY = 30.0f;
    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    void SpawnRandomBall()
    {
        int randomBall = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[0].transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
