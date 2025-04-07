using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner2 : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;
    public float minX = 30;
    public float maxX = 25;
    public float startDelay;
    public float spawnIn;
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
    }
}
