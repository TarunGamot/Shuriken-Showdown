using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDelay : MonoBehaviour
{
    public AudioSource dasherSound;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        dasherSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        dasherSound.PlayDelayed(delay);
    }
}
