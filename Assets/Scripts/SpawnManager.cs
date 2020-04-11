using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private int spawnXMax = 18;
    private float startSpawnDelay = 1;
    private float spawnIntervalTime = .8f;
    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startSpawnDelay, spawnIntervalTime);
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        GameObject animal = animalPrefab[animalIndex];
        Vector3 spawnPos = new Vector3(Random.Range(-spawnXMax, spawnXMax), animal.transform.position.y, Random.Range(17, 19));
        Instantiate(animal, spawnPos, animal.transform.rotation);
    }
}
