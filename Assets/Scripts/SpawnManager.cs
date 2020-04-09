using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private int spawnXMax = 18;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0,animalPrefab.Length);           
            GameObject animal = animalPrefab[animalIndex];
            Vector3 spawnPos = new Vector3(Random.Range(-spawnXMax, spawnXMax), animal.transform.position.y, Random.Range(17, 19));
            Instantiate(animal, spawnPos,animal.transform.rotation);
        }
    }
}
