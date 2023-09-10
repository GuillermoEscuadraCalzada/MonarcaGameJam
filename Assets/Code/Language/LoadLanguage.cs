using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Events;


public class LoadLanguage : MonoBehaviour
{
    static Dictionary<string, string> dictionaryGame;

    public delegate void Translate();
    public event Translate TranslateLang;

    private static Language _gameData;

    // Start is called before the first frame update
    void Start()
    {
        _gameData = new Language();
        LoadGameData();
        SetData(_gameData);
    }


    public static Language LoadGameData()
    {
        //string filePath = Path.Combine(Application.streamingAssetsPath, "Languages.json");
        //string json = File.ReadAllText(filePath);

        //_gameData = JsonUtility.FromJson<Language>(json);
        //return _gameData;
        return _gameData;
    }

    private void SetData(Language gd)
    {
        SetDictionary();
        TranslateGame();
    }

    private static void SetDictionary()
    {
        //dictionaryGame = new Dictionary<string, string>();
        //for (int i = 0; i < _gameData.dictionaryGame.Count; i += 2)
        //{
        //    dictionaryGame.Add(_gameData.dictionaryGame[i], _gameData.dictionaryGame[i + 1]);
        //}
        //Debug.Log(dictionaryGame);
    }

    public void TranslateGame()
    {
        // TranslateLang();
    }


    public string TextID(string id)
    {
        return "";
        //foreach (KeyValuePair<string, string> kvp in dictionaryGame)
        //{
        //    if (kvp.Key == id)
        //    {
        //        Debug.Log(kvp.Value);
        //        return kvp.Value;
        //    }
        //}

        //return null;
    }
}
