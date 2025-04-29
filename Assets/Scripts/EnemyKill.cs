using UnityEngine;

public class EnemyKill : MonoBehaviour
{
    public GameObject Hit;
    public GameObject OrangeSplash;
    public AudioSource HitSound;
    private Counter counterScript;

    private void Start()
    {
        counterScript = GetComponentInParent<Counter>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Elephant"))
        {
            GameObject hit = Instantiate(Hit, collision.transform);
            hit.transform.SetParent(null);

            counterScript.IncriminateCount();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

        if (collision.CompareTag("Rock"))
        {
            GameObject orangeSplash = Instantiate(OrangeSplash, collision.transform.position, Quaternion.identity);
            Vector2 position = collision.transform.position;
            position.y += 8.6f;
            orangeSplash.transform.position = position;
            orangeSplash.transform.SetParent(null);
            Destroy(this.gameObject);
        }
    }
}
