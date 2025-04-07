using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManger : MonoBehaviour
{
    
    public AudioSource dasher;
    // Start is called before the first frame update
    void Start()
    {
       
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void PlaySound()
    {
        dasher.Play();
    }
}
