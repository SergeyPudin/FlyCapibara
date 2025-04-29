using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private CoinCounter _coinCounter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<WallForOranges>())
        {
            this.gameObject.SetActive(false);
        }

        if (collision.CompareTag("Elephant"))
        {
            _counter.IncriminateCount();
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Coin"))
        {
            _coinCounter.IncriminateCoinCount();
            Destroy(collision.gameObject);
        }
    }
}