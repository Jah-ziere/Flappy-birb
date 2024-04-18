using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 0.1f;
    Bird BirdScript;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(BirdScript.isAlive == true)
        {
            transform.Translate(Vector2.left * Time.deltaTime);
        }
      
        
        
    }

    void Awake()
    {
        BirdScript = GameObject.Find("bird").GetComponent<Bird>();
    }

}
