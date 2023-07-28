using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PersistenceManager : MonoBehaviour
{

    public static PersistenceManager Instance;

    public string playerName;
    public int bestScore = 0;

    [System.Serializable]
    class SaveData
    {
        public int bestScore;
    }




    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(Instance);

    }

    public void Save()
    {
        SaveData data = new SaveData();
        data.bestScore = this.bestScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void Load()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            this.bestScore = data.bestScore;
        }
        
    }
}
