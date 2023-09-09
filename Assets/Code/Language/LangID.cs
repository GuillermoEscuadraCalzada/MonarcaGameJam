using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LangID : MonoBehaviour
{
    public string id;
    [SerializeField] private LoadLanguage gameData;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        gameData = GameObject.Find("GameData").GetComponent<LoadLanguage>();
        gameData.TranslateLang += Translate;
    }

    private void Translate()
    {
        text.text = gameData.TextID(id);
    }
}
