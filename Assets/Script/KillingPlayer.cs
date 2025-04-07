using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class KillingPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject gO;




    // Start is called before the first frame update
    void Start()
    {
        gO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D n)
    {
        
        if (n.gameObject.tag == "Enemy")
        {
           
           Destroy(player);
         
            Time.timeScale = 0f;
            gO.SetActive(true);
           
        }
    }
    
}
