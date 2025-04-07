using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killingdasher : MonoBehaviour
{
    private ShakingScreen shake;

    // Start is called before the first frame update
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("SS").GetComponent<ShakingScreen>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D n)
    {

        if (n.gameObject.tag == "Dasher")
        {

            Destroy(n.gameObject);
            shake.CamShake();
        }
    }
}
