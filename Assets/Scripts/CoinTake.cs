using UnityEngine;

public class CoinTake : MonoBehaviour
{
    public CoinCounter CounterScript;
    public AudioSource CoinSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            CounterScript.IncriminateCoinCount();
            Destroy(collision.gameObject);
            CoinSound.Play();
        }
    }
}
