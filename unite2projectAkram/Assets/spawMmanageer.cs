using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class spawMmanageer : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 10;
    private float spawnRangeZ = 14;
    private float spawnPosX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", spawnDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", spawnDelay, spawnInterval);
    }


    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(0, spawnRangeZ));
        Quaternion rotationLeft = Quaternion.Euler(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, rotationLeft);
    }
    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(0, spawnRangeZ));
        Quaternion rotationRight = Quaternion.Euler(0, 270, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, rotationRight);

    }
}




