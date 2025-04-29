using UnityEngine;
using UnityEngine.UI;

public class LiveButton : MonoBehaviour
{
    [SerializeField] private Button _liveButton;
  
    private void Start()
    {
        GetImageInvisible();
    }

    public void GetImageInvisible()
    {

        Image image = _liveButton.GetComponent<Image>();

        Color color = image.color;
        color.a = 0.3f;
        image.color = color;
    }

    public void GetImageVisible()
    {
        Image image = _liveButton.GetComponent<Image>();

        Color color = image.color;
        color.a = 0.8f;
        image.color = color;
    }
}
