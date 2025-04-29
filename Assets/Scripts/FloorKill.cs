using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorKill : MonoBehaviour
{
    public string levelName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
