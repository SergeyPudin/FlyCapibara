using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleDestroy : MonoBehaviour
{
    public GameObject OrangeSplash;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rock"))
        {
            GameObject orangeSplash = Instantiate(OrangeSplash, collision.transform.position, Quaternion.identity);
            Vector2 position = collision.transform.position;
            position.y += 8.6f;
            orangeSplash.transform.position = position;
            orangeSplash.transform.SetParent(null);
            Destroy(this.gameObject);
        }
    }
}
