using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;


public class RuneSelector : MonoBehaviour
{
    [SerializeField] private AudioSource m_as; // as is the underscore for audiosource typically. 
    [SerializeField] private AudioSource m_correctRuneSeleceted_as;
    [SerializeField] private AudioSource m_wrongRuneSelected_as;

    //[SerializeField] private GameManager m_GMScript; // creating game manager script variable

    [SerializeField] private TextMeshProUGUI m_text;

    [SerializeField] public int oppsieCountDown = 3;
    [SerializeField] public int oppsieCountDownDelay = 1;


    [SerializeField] private UnityEngine.UI.Button[] m_buttons;
    
    public int[] m_currentRuneSequence = new[] { 1, 2, 3, 4 };
    public int m_currentIndex = 0;
    [SerializeField] private TextMeshProUGUI topscreenanouncement;
    
    public void OnRuneActivated( int index)
    {
        // if the current index is greater than or equal to the length of the m_currentRuneSequence length array return. 
        if (m_currentIndex >= m_currentRuneSequence.Length) return; // Guard clause...

        // if the m_currentRuneSequence at the current index is equal to the index the...
        if(m_currentRuneSequence[m_currentIndex] == index)
        {
            // run the correct selected method
            CorrectSelected();
            // increase the value of m_currentIndex.
            m_currentIndex++;
        }
        // otherwise return the current index back to zero. 
        else
        {
            Failed();
            m_currentIndex = 0;
        }

    }

    private void Failed()
    {
        m_wrongRuneSelected_as.Play();
        m_currentIndex = 0;
        StartCoroutine(FailedMethod());
        
        

    }

    private void CorrectSelected()
    {

        m_currentIndex++;
        m_correctRuneSeleceted_as.Play();
        GameManager.s_instance.AddScore(10);
        // Logic
        if (m_currentIndex == m_currentRuneSequence.Length)
        {
            sequenceCompleted();
        }


    }

    private void sequenceCompleted()
    {
        m_text.text = "Yay all correct";

    }

    private IEnumerator FailedMethod()
    {

        topscreenanouncement.text = "ooopsie ....";
        buttonToggleInteraction(false);
        m_text.text = "Failed!";

        // restartthegame function ....reEnableGame
        StartCoroutine(reEnableRunes());

        yield return null;
    }


    IEnumerator AnnouncerCoroutine(int count, int delay)
    {
        for (int i = count; i >=0; i--)
        {
            m_text.text = i.ToString();
            yield return new WaitForSeconds(delay);
        }
    }


    private IEnumerator reEnableRunes()
    {
        yield return StartCoroutine(AnnouncerCoroutine(oppsieCountDown, oppsieCountDownDelay));
        m_text.text = "Go!";
        buttonToggleInteraction(true);

        yield return null;
    }


    private void buttonToggleInteraction ( bool btn_Toggle)
    {
        foreach ( var runeButton in m_buttons)
        {
            runeButton.interactable = btn_Toggle; 
        }

    }
}
