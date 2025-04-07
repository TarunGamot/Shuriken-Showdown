using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DasherEnemySpeed : MonoBehaviour
{
    public float speed = -20;
    public ParticleSystem dashEffect;
   


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    public void OnTriggerEnter2D(Collider2D op)
    {
        if (op.gameObject.tag == "AttackZone")
        {
            dashEffect.Play();
          
           

        }

    }
   
}
