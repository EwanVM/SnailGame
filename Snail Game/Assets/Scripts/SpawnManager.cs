using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] stonePrefabs;
    private float spawnRangeZ = 10;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomStone", 1, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomStone()
    {
        int stoneIndex = Random.Range(0, stonePrefabs.Length);
        Instantiate(stonePrefabs[stoneIndex], new Vector3(50, 5, Random.Range(-spawnRangeZ, spawnRangeZ)), stonePrefabs[stoneIndex].transform.rotation);
    }
}
