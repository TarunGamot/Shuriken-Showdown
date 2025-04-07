using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyshuriken : MonoBehaviour
{
    private float rightBound = 24;
    private float leftBound = -24;
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
