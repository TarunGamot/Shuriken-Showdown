using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingPlayerWithShuriken : MonoBehaviour
{
    public GameObject player;
    public GameObject gO;
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
        if (n.gameObject.tag == "ES")
        {
            Destroy(player);
            Time.timeScale = 0f;
            gO.SetActive(true);
        }
    }
}
