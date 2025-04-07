using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDieZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D e)
    {
        if(e.gameObject.tag == "Enemy")
        {
            Destroy(e.gameObject);
        }
    }
}
