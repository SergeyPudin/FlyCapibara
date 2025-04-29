using UnityEngine;
using UnityEngine.UI;

public class CapyFlyer : MonoBehaviour
{
    public Rigidbody2D RigidbodyBase;
    public float FlyForce;
    public Animator CapyAnimator;
    public AudioSource Wing;
    public Button FlyButton;

    private void Start()
    {
        FlyButton.onClick.AddListener(Fly);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Fly();
        }
    }

    private void Fly()
    {
            RigidbodyBase.linearVelocity = Vector2.zero;
            RigidbodyBase.AddForce(Vector2.up * FlyForce);
            CapyAnimator.SetTrigger("Fly");
            Wing.Play();
    }
}
