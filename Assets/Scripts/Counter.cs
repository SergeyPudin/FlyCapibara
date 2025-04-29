using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
   [SerializeField] private TMP_Text _countText;
    
    public int CurrentCount;

    private void Awake()
    {
        CurrentCount = 0;
        _countText.text = CurrentCount.ToString();
    }

    public void IncriminateCount()
    {
        CurrentCount++;
        _countText.text = CurrentCount.ToString();
    }

    public void Secret()
    {
        if (CurrentCount == 1000000)
        {
            SceneManager.LoadScene("SecretScene");
        }
    }
}
