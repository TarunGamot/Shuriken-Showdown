using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedToEnemy : MonoBehaviour
{
    public float speed = 5;
    public float shurikenSpeed = 15;
    public GameObject shurikenPrefabs;
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
        if(op.gameObject.tag == "AttackZone")
        {
            //speed = 0;
            GameObject shoot = Instantiate(shurikenPrefabs, transform.position, shurikenPrefabs.transform.rotation);
            Rigidbody2D rb2D = shoot.GetComponent<Rigidbody2D>();
            rb2D.AddForce(transform.right * shurikenSpeed, ForceMode2D.Impulse);
        }

    }
    
}
