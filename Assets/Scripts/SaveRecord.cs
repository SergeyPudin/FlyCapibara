using UnityEngine;
using System.IO;

public class SaveRecord : MonoBehaviour
{
    [SerializeField] private Counter _counter;

    public void SaveNumber(int record)
    {
        string saveFile = Application.persistentDataPath + "/save.txt";

        if (File.Exists(saveFile))
        {
            string stringRecord = File.ReadAllText(saveFile);
            int number = int.Parse(stringRecord);

            if (_counter.CurrentCount > number)
            {
                File.WriteAllText(saveFile, record.ToString());
            }
        }
    }
}
