using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] stonePrefabs;
    private float spawnRangeZ = 10;
    // Start is called before the first frame update
    void Start()
    {// Makes the SpawnRandomStone code repeat every 1.5 seconds
        InvokeRepeating("SpawnRandomStone", 0, 1.5f);
    }

    void SpawnRandomStone()
    {// makes a random stone spawn at a random z value between 10 and -10 (up and dowm)
        int stoneIndex = Random.Range(0, stonePrefabs.Length);
        Instantiate(stonePrefabs[stoneIndex], new Vector3(50, 5, Random.Range(-spawnRangeZ, spawnRangeZ)), stonePrefabs[stoneIndex].transform.rotation);
    }
}
