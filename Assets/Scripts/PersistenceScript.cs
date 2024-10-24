using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class PersistenceScript : MonoBehaviour
{
    public static PersistenceScript instance;

    public string currentPlayerName;

    public int currentScore;

    public int HighScore;

    public string HighScoreName;

    private void Awake()
        {
        if (instance != null)
            {
            Destroy(gameObject);
            return;
            }

        instance = this;
        DontDestroyOnLoad(gameObject);

        LoadHighScore();
        }

    [System.Serializable]

    public class SaveData
        {
            public int HighScore;
            public string HighScoreName;
        }

    public void SaveHighScore()
        {
        SaveData data = new SaveData();
        data.HighScoreName = HighScoreName;
        data.HighScore = HighScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/SaveHighScore.json", json);
        }

    public void LoadHighScore()
        {
        string path = Application.persistentDataPath + "/SaveHighScore.json";
        if (File.Exists(path))
            {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            HighScoreName = data.HighScoreName;
            HighScore = data.HighScore;
            }
        }

}
