using UnityEngine;
using UnityEngine.SceneManagement;

public class WallForElephants : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Elephant") || collision.CompareTag("Apple") || collision.CompareTag("Rock"))
        {
            Destroy(collision.gameObject);
        }
    }
}
