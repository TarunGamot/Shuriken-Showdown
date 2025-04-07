using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillingScript : MonoBehaviour
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
       
        if (n.gameObject.tag == "Enemy")
        {
           
            Destroy(n.gameObject);
            shake.CamShake();
        }
    }
}
