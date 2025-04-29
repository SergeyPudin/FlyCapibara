using UnityEngine;
using UnityEngine.UI;

public class CapiThrow : MonoBehaviour
{
    public Animator CapyAnimator;
    public GameObject Orange;
    public Transform OrangePosition;
    public float OrangeSpeed;
    public AudioSource ThrowSound;
    public Button ThrowButton;

    private void Start()
    {
            ThrowButton.onClick.AddListener(GetAnimation);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetAnimation();
        }
    }
    
    public void Throw()
    {
        Instantiate(Orange, OrangePosition).GetComponent<Rigidbody2D>().linearVelocity = new Vector2(1,0) * OrangeSpeed;
        ThrowSound.Play();
    }

    private void GetAnimation()
    {
            CapyAnimator.SetTrigger("Throw");
    }
}
