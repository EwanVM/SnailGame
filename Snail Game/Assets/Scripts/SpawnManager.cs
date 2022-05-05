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
        
    }

    // Update is called once per frame
    void Update()
    {if (Input.GetKeyDown(KeyCode.S))
        {
            int stoneIndex = Random.Range(0, stonePrefabs.Length);
            Instantiate(stonePrefabs[stoneIndex], new Vector3(24, 2, Random.Range()), stonePrefabs[stoneIndex].transform.rotation);
        }
        
    }
}
