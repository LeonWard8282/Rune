using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // using this library to interact with unity User Interface "Images"

public class Rune : MonoBehaviour
{
    [SerializeField] private Color m_activationColor; //activation collor for when we click it. 
    [SerializeField] private AudioSource m_audioSource; // audio source for when its clicked. 
    [SerializeField] private Image m_runeImage; // the image of the rune itself that we will change the color for. 
    [SerializeField] private float m_colorTransitionDuration = 0.3f; // color transition rune from when we click on a rune
    [SerializeField] private float m_minActivationDuration = 0.3f;  // how long will it take to activate this change. 

    private Coroutine m_coroutine; 

    public void RuneClick()
    {

        StopAllCoroutines(); // this only works for its individual script.

        //StartCoroutine(ActivateRune());

        m_coroutine = StartCoroutine(ActivateRune()); // by putting it into a variable you have more control in stoping a coroutine. 
        // dosnt make sense to use this locally but its good to use if for a global script. 

       // StopCoroutine(m_coroutine);

    }

    private IEnumerator ActivateRune()
    {
       // m_audioSource.Play();

        yield return LerpToColor(Color.white, m_activationColor);

        yield return new WaitForSeconds(m_minActivationDuration);

        float duration = m_audioSource.clip.length; // gets us how long the audio source is. 

        while(m_audioSource.isPlaying)
        {
            yield return new WaitForEndOfFrame();

        }


        yield return LerpToColor(m_activationColor, Color.white);

    }
    
    private IEnumerator LerpToColor(Color start, Color end) // giving it arguments to pass in information into the argument
    {

        float elapsedTime = 0;
        float startTime = Time.time;

        while(elapsedTime < m_colorTransitionDuration)
        {
            m_runeImage.color = Color.Lerp(start, end, elapsedTime / m_colorTransitionDuration);
            elapsedTime = Time.time - startTime;
            yield return null;
        }


        // instead of waitfor, you can use the null
        yield return null; // this will satisfy the argu,ent aside from the yield waitforTime()

    }


}
