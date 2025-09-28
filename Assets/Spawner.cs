using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyprefab;

    public float spawnTimer;

    public float spawnInterval;

    public float minDistance;
    public float maxDistance;

    private float distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            spawnTimer = 0;
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        float angleDegre = Random.Range(0f, 360f);
        float angleRad = angleDegre * Mathf.Deg2Rad;
        float distance = Random.Range(minDistance, maxDistance);
        Vector2 SpawnPosition = new Vector2(Mathf.Cos(angleRad) * distance, Mathf.Sin(angleRad)* distance);
        Instantiate(enemyprefab, SpawnPosition, Quaternion.identity);
    }
}
