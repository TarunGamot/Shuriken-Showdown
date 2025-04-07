using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorScript : MonoBehaviour
{
    public GameObject Ind;
    public GameObject Tar;
    Renderer rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rd.isVisible == false)
        {
            if(Ind.activeSelf == false)
            {
                Ind.SetActive(true);
            }
            Vector2 dir = Tar.transform.position - transform.position;
            RaycastHit2D ray = Physics2D.Raycast(transform.position, dir);
            if(ray.collider != null)
            {
                Ind.transform.position = ray.point;
            }
        }
        else
        {

            if (Ind.activeSelf == true)
            {
                Ind.SetActive(false);
            }
        }
        
    }
}
