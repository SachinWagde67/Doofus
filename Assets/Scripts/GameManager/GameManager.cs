using UnityEngine;
using System.IO;
using Newtonsoft.Json;

public class GameManager : SingletonGeneric<GameManager>
{
    public Data data;

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
}
