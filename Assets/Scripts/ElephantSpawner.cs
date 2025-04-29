using UnityEngine;

public class ElephantSpawner : MonoBehaviour
{
    public GameObject Elephant;
    public Transform ElephantSpawn;
    public Transform ElephantSpawn2;
    public Transform ElephantSpawn3;
    public float SpawnTime;
    public float ElephantSpeed;
    public float DifficultTime;
    private float currentDifficultTime;
    public float SpawnTimeCoefficient;

    private float currentTime;

    private void Start()
    {
        currentTime = SpawnTime;
        currentDifficultTime = DifficultTime;
    }
    private void Update()
    {
        if (currentTime <= 0) 
        {
            SpawnElephant();
            currentTime = SpawnTime;
        }
        else
        {
            currentTime  = currentTime - Time.deltaTime;
        }

        if (currentDifficultTime <= 0)
        {
            SpawnTime += SpawnTimeCoefficient;
            currentDifficultTime = DifficultTime;
        }
        else
        {
            currentDifficultTime -= Time.deltaTime;
        }
    }

    private void SpawnElephant()
    {
        int index = Random.Range(0, 3);
        Transform spawner;

        if (index == 0)
        {
            spawner = ElephantSpawn;
        }
        else if(index == 1)
        {
            spawner = ElephantSpawn2;
        }
        else
        {
            spawner = ElephantSpawn3;
        }

        Instantiate(Elephant, spawner).GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-1,0) * ElephantSpeed;
    }
}
