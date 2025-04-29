using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public GameObject TopRock;
    public GameObject BottomRock;
    public Transform TopSpawnPoint;
    public Transform BottomSpawnPoint;
    public float RockSpawnTime;
    public float RockSpeed;
    private float currentRockSpawnTime;

    private void Start()
    {
        currentRockSpawnTime = RockSpawnTime;
    }

    private void Update()
    {
        if (currentRockSpawnTime <= 0)
        {
            RockSpawn();
            currentRockSpawnTime = RockSpawnTime;
        }
        else
        {
            currentRockSpawnTime -= Time.deltaTime;
        }
    }

    private void RockSpawn()
    {
        GameObject currentPrefab;
        Transform currentSpawnPoint = GetRandomSpawnPoint();

        if (currentSpawnPoint == TopSpawnPoint)
        {
            currentPrefab = TopRock;
        }
        else
        {
            currentPrefab = BottomRock;
        }

        Instantiate(currentPrefab, currentSpawnPoint).GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-1, 0) * RockSpeed;
    }

    private Transform GetRandomSpawnPoint()
    {
        int index = Random.Range(0, 2);
        
        if (index == 0)
        {
            return TopSpawnPoint;
        }
        else
        {
            return BottomSpawnPoint;
        }
    }
}
