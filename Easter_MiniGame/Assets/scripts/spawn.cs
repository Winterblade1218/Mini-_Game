using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] Prefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = -29;
    private float spawnY = 5;
    private float startDelay = 2;

    private float spawnInterval = 0.7f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
     void SpawnEnemy()
    {
          Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnY, spawnPosZ);
            int EnemyIndex = Random.Range(0, Prefabs.Length);
            Instantiate(Prefabs[EnemyIndex], spawnPos, Prefabs[EnemyIndex].transform.rotation);
    
    }
}
