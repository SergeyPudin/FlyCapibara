using UnityEngine;

public class ElephantShoot : MonoBehaviour
{
    public GameObject Apple;
    public float MaxTime;
    private float currentTime;
    public float MinTime;
    public Transform SpawnPoint;
    public float AppleSpeed;
    public Animator ElephantAnimator;
    public AudioSource ElephantWing;
    public AudioSource ElephantShootSound;

    void Start()
    {
        currentTime = GetRandom();
    }
    
    void Update()
    {
        if (currentTime <= 0)
        {
            PlayAnimation();
            currentTime = GetRandom();
        }
        else
        {
            currentTime -= Time.deltaTime;
        }

    }

    public void Throw()
    {
        GameObject apple = Instantiate(Apple, SpawnPoint);
        apple.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-1, 0) * AppleSpeed;
        apple.transform.SetParent(null);
        SoundShoot();
    }

    public void SoundWing()
    {
        ElephantWing.Play();
    }

    private void SoundShoot()
    {
        ElephantShootSound.Play();
    }

    private void PlayAnimation()
    {
        ElephantAnimator.SetTrigger("Throw");
    }

    private float GetRandom()
    {
        return Random.Range(MinTime, MaxTime);
    }
}
