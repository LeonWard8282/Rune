using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class testEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent m_click;
    private AudioSource _audioSource;
    public Text scoreText;
    public Text highschoreText;

    int score = 0;
    int highscore = 0; 

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        scoreText.text = score.ToString() + "Points";
        highschoreText.text =  "highscore:" + highscore.ToString();
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            m_click.Invoke();
        }


    }

    public void jingle()
    {
        _audioSource.Play();

    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " Points";
    }
}
