using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DasherSpwanner : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;
    public float minX = -30;
    public float maxX = -25;
    public float startDelay;
    public float spawnIn;
    public AudioSource indi;
    public AudioSource dasherSound;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, spawnIn);
  
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, EnemyPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), -3.697f, -1);
        Instantiate(EnemyPrefabs[enemyIndex], spawnPosition, EnemyPrefabs[enemyIndex].transform.rotation);
        indi.Play();
        dasherSound.Play();
        StartCoroutine(playSoundAfterOneSeconds());

    }
    IEnumerator playSoundAfterOneSeconds()
    {
        yield return new WaitForSeconds(1);
        dasherSound.Play();
    }
}
