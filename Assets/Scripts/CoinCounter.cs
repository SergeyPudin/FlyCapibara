using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private LiveButton _liveButton;
    [SerializeField] private BombButton _bombButton;
    [SerializeField] private Health _health;
    [SerializeField] private int _heartPrice;
    [SerializeField] private int _bombPrice;

    public TMP_Text CoinCount; 
    private int currentCoinCount;
    

    private void Awake()
    {
        _liveButton.gameObject.GetComponent<Button>().onClick.AddListener(BuyHearts);
        _bombButton.gameObject.GetComponent<Button>().onClick.AddListener(BombExplode);

        currentCoinCount = 0;
        CoinCount.text = currentCoinCount.ToString();
        CheckButtons();
    }

    public void IncriminateCoinCount()
    {
        currentCoinCount++;
        CoinCount.text = currentCoinCount.ToString();
        CheckButtons();
    }

    private void CheckButtons()
    {
        if (currentCoinCount >= _heartPrice)
        {
            _liveButton.GetImageVisible();
        }

        if (currentCoinCount < _heartPrice)
        {
            _liveButton.GetImageInvisible();
        }

        if (currentCoinCount >= _bombPrice)
        {
            _bombButton.GetImageVisible();
        }

        if (currentCoinCount < _bombPrice)
        {
            _bombButton.GetImageInvisible();
        }
    }

    private void BuyHearts()
    {
        if (currentCoinCount >= _heartPrice)
        {
            currentCoinCount -= _heartPrice;
            CoinCount.text = currentCoinCount.ToString();
            _health.IncriminateHealth();
            CheckButtons();
        }
    }

    private void BombExplode()
    {
        if (currentCoinCount >= _bombPrice)
        {
            currentCoinCount -= _bombPrice;
            CoinCount.text = currentCoinCount.ToString();

            _bombButton.Explode();

            CheckButtons();
        }
    }
}
