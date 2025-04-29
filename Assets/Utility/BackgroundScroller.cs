using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Renderer _renderer;

    private Vector2 _startOffset;

    private void Start()
    {
        _startOffset = _renderer.material.mainTextureOffset;
    }

    private void Update()
    {
        float offsetX = Mathf.Repeat(Time.time * _speed, 1);
        Vector2 offset = new Vector2(offsetX, _startOffset.y);

        _renderer.material.mainTextureOffset = offset;
    }

    private void OnDisable()
    {
        _renderer.material.mainTextureOffset = _startOffset;
    }
}