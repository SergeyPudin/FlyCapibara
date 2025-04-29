using UnityEngine;
using UnityEngine.SceneManagement;

public class CapiDie : MonoBehaviour
{
    [SerializeField] private Health _health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Elephant") || collision.CompareTag("Rock") || collision.CompareTag("Apple"))
        {
            _health.DecriminateHealth();
        }
    }
}
