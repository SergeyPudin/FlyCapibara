using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallForOranges : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Orange"))
        {
            Destroy(collision.gameObject);
        }
    }
}
