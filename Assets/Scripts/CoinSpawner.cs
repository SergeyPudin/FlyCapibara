using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public Transform SpawnPosition1;
    public Transform SpawnPosition2;
    public Transform SpawnPosition3;
    public float SpawnTime;
    public GameObject CoinPrefab;
    public float CoinSpeed;
    private float currentSpawnTime;


    private void Start()
    {
        currentSpawnTime = SpawnTime;
    }

    private void Update()
    {
        if (currentSpawnTime <= 0)
        {
            SpawnCoin();
            currentSpawnTime = SpawnTime;
        }
        else
        {
            currentSpawnTime -= Time.deltaTime;
        }
    }

    private void SpawnCoin()
    {
        Instantiate(CoinPrefab, GetRandomSpawnPoint()).GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-1, 0) * CoinSpeed;
    }

    private Transform GetRandomSpawnPoint()
    {
        int index = Random.Range(0, 3);

        if (index == 0)
        {
            return SpawnPosition1;
        }
        else if(index == 1)
        {
            return SpawnPosition2;
        }
        else
        {
            return SpawnPosition3;
        }

        
    }
}
