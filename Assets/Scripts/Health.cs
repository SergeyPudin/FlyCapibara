using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private GameObject _heart1;
    [SerializeField] private GameObject _heart2;
    [SerializeField] private GameObject _heart3;
    [SerializeField] private float _deadTime;
    [SerializeField] private GameObject _fx;
    [SerializeField] private SaveRecord _saveRecord;
    [SerializeField] private Counter _counter;

    private int _currentHealth;
    private int _maxHealth;
    private int _minHealth;
    private bool _isDead;
    private float _currentTime;

    private void Start()
    {
        _maxHealth = 3;
        _minHealth = 0;
        _currentHealth = 1;
        _isDead = false;
        _currentTime = _deadTime;

        HeartCounter();
    }

    private void Update()
    {
        if (_isDead)
        {
            _currentTime -= Time.deltaTime;
        }

        if (_currentTime <= 0)
        {
            LoseScene();
        }
    }

    public void IncriminateHealth()
    {
        _currentHealth = Mathf.Clamp((_currentHealth + 1), _minHealth, _maxHealth);
        HeartCounter();
    }

    public void DecriminateHealth()
    {
        _currentHealth = Mathf.Clamp((_currentHealth - 1), _minHealth, _maxHealth);
        HeartCounter();
    }

    private void LoseScene()
    {
        SceneManager.LoadScene("LoseScene");
    }

    private void HeartCounter()
    {
        if (_currentHealth == 0)
        {
            _heart1.SetActive(false);
            _heart2.SetActive(false);
            _heart3.SetActive(false);

            OnDie();

            _isDead = true;
        }
        else if (_currentHealth == 1)
        {
            _heart1.SetActive(true);
            _heart2.SetActive(false);
            _heart3.SetActive(false);
        }
        else if (_currentHealth == 2)
        {
            _heart1.SetActive(true);
            _heart2.SetActive(true);
            _heart3.SetActive(false);
        }
        else
        {
            _heart1.SetActive(true);
            _heart2.SetActive(true);
            _heart3.SetActive(true);
        }
    }

    private void OnDie()
    {
        Instantiate(_fx, this.transform);

        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        Color color = renderer.color;

        color.a = 0;
        renderer.color = color;

        _saveRecord.SaveNumber(_counter.CurrentCount);
    }
}
