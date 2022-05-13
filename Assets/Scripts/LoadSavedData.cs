using System.IO;
using UnityEngine;

public class LoadSavedData : MonoBehaviour
{
    public void OnApplicationQuit()
    {
        SaveData data = new SaveData(); // creatinga  temp save data;
        data.highScore = "10";

       
        // creating a string
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/SaveData.json", json);
        PlayerPrefs.SetString("HighScore", "True");
    }

    // when the script turns on this runs right away. 
    private void Awake() 
    {
       // if(File.Exists(Application.dataPath + "/SaveData.json"))
        if(PlayerPrefs.HasKey("HighScore"))
        {
            string json = File.ReadAllText(Application.dataPath + "/SaveData.json");
            SaveData data = JsonUtility.FromJson<SaveData>(json);



            //demenstration on how to convert inter to string and string to integer
            int x = 10;
            x.ToString();

            int y = int.Parse(data.highScore);


        }

       
    }



}
