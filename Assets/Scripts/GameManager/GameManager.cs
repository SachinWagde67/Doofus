using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using TMPro;

public class GameManager : SingletonGeneric<GameManager>
{
    public Data data;

    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreTxt;

    public override void Awake()
    {
        base.Awake();
        ParseGameData();
    }

    private void ParseGameData()
    {
        string path = Application.dataPath + "/Resources/doofus_diary.json";
        StreamReader streamReader = File.OpenText(path);
        string json = streamReader.ReadToEnd();
        data = JsonConvert.DeserializeObject<Data>(json);
    }

    public void increaseScore()
    {
        score++;
        scoreTxt.text = "Score : " + score.ToString(); 
    }
}
