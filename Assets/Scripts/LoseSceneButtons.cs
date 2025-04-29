using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoseSceneButtons : MonoBehaviour
{
    public Button ToMainMenuButton;
    public Button RestartButton;

    void Start()
    {
        ToMainMenuButton.onClick.AddListener(ToMainMenu);
        RestartButton.onClick.AddListener(RestartGame);
    }

    void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void RestartGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
