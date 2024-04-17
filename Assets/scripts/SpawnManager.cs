using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject PipesPrefab;
    float randomHeight = 0.5343488f;
    Bird BirdScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 1.0f, 1.0f);
        BirdScript = GameObject.Find("bird").GetComponent<Bird>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BirdScript.isAlive == false)
        {
            CancelInvoke();
        }
    }

    void SpawnPipes()
    {
        Instantiate(PipesPrefab, new Vector2(8, Random.Range(-randomHeight, randomHeight)), Quaternion.identity);
    }

}

