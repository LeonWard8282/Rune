using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager s_instance; // s underscore is common syntax for static singleton. 

    [SerializeField] private TextMeshProUGUI m_highscoreText;
    [SerializeField] private TextMeshProUGUI m_currentScoreText;
    [SerializeField] private GameManager m_GMScript;
    
    private int m_currentScore;
    private int m_highscore;
    private string m_scoreKey = "HighScore";


    public void AddScore(int points) // creating an integer here where we can call this function from this class. 
    {
        m_currentScore += points; // m_CurrentScore = m_CurrentScore + points
        m_currentScoreText.text = m_currentScore.ToString();

        if(m_currentScore > m_highscore)
        {
            m_highscore = m_currentScore;
            m_highscoreText.text = m_highscore.ToString();

        }

    }


    private void Awake()
    {

        if(s_instance == null)
        {
            s_instance = this;
        }
        else
        {
            Debug.Log("Multiple singleton Instances!");
        }
        
        if( File.Exists(Application.dataPath + "/SaveData.json"))
        {
            string json = File.ReadAllText(Application.dataPath + "/SaveData.json");
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            m_highscore = int.Parse(data.highScore);
            m_highscoreText.text = m_highscore.ToString();



        }


    }

    private void OnApplicationQuit() //saving
    {
      if(m_currentScore >= m_highscore)
        {
            SaveData data = new SaveData();
            data.highScore = m_currentScore.ToString();

            string json = JsonUtility.ToJson(data);
            File.WriteAllText(Application.dataPath + "/SaveData.json", json);


        }

        
    }


}
