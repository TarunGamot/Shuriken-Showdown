using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDasher : MonoBehaviour
{
    private float rightBound = 41;
    private float leftBound = -41;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

    }
}
