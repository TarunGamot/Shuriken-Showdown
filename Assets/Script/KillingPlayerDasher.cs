using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingPlayerDasher : MonoBehaviour
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

        if (n.gameObject.tag == "Dasher")
        {

            Destroy(player);

            Time.timeScale = 0f;
            gO.SetActive(true);

        }
    }
}   
