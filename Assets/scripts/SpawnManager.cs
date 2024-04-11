using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject PipesPrefab;
    float randomHeight = 0.5343488f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipes()
    {
        Instantiate(PipesPrefab, new Vector2(8, Random.Range(-randomHeight, randomHeight)), Quaternion.identity);
    }

}

