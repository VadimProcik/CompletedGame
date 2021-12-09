using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float leftBound = 105;
    private float rightBound = -85;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > leftBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < rightBound)
        { 
            Destroy(gameObject);
        }
    }
}
