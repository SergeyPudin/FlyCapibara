using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Apple"))
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
