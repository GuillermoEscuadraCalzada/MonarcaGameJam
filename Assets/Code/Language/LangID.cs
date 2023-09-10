using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LangID : MonoBehaviour
{
    public string id;
    private LoadLanguage gameData;
    private Text text;
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<Text>();
        gameData = GameObject.Find("GameData").GetComponent<LoadLanguage>();
        gameData.TranslateLang += Translate;
    }

    private void OnEnable()
    {
        Translate();
    }

    public void Translate()
    {
        text.text = gameData.TextID(id);
    }

    public void Translate(string i)
    {
        id = i;
        text.text = gameData.TextID(id);
    }
}
