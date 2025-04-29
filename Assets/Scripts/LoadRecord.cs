using UnityEngine;
using TMPro;
using System.IO;

public class LoadRecord : MonoBehaviour
{
    [SerializeField] private TMP_Text _recordText;

    private void Start()
    {
        ShowRecord();
    }

    private void ShowRecord()
    {
        int record;
        string saveFile = Application.persistentDataPath + "/save.txt";

        if (File.Exists(saveFile))
        {
            string stringRecord = File.ReadAllText(saveFile);
            int number = int.Parse(stringRecord);
            record = number;

            _recordText.text = number.ToString();
        }
    }
}
