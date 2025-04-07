using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorSpawnner : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;
    public float minX;
    public float maxX;
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
        Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), -30.0f, -1);
        Instantiate(EnemyPrefabs[enemyIndex], spawnPosition, EnemyPrefabs[enemyIndex].transform.rotation);
       // StartCoroutine("WaitForSec");
    }
   // IEnumerator WaitForSec()
   // {
       // yield return new WaitForSeconds(40);
        
   // }
}
