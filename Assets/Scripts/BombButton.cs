using UnityEngine;
using UnityEngine.UI;

public class BombButton : MonoBehaviour
{
    [SerializeField] private Button _bombButton;
    [SerializeField] private GameObject _bomb;
    [SerializeField] private Transform _bombPosition;
    [SerializeField] private float _bombSpeed;

    private void Start()
    {
        GetImageInvisible();
    }

    public void GetImageInvisible()
    {

        Image image = _bombButton.GetComponent<Image>();

        Color color = image.color;
        color.a = 0.3f;
        image.color = color;
    }

    public void GetImageVisible()
    {
        Image image = _bombButton.GetComponent<Image>();

        Color color = image.color;
        color.a = 0.8f;
        image.color = color;
    }

    public void Explode()
    {
        _bomb.SetActive(true);
        _bomb.transform.position = _bombPosition.position;

        _bomb.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(1, 0) * _bombSpeed;
    }
}
