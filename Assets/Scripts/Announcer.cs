using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [RequireComponent(typeof(Rigidbody)]

public class Announcer : MonoBehaviour
{

    [SerializeField] [Range(-2, 2f)] private float m_bounceAmplitude = 0.01f; // private, public, or protected. protected is used with inheritance. asscessible but used in another script. with the range it makes it into a slider. 
    [SerializeField] [Range(-2, 2f)] private float m_bounceFrequency = 0.01f;


    // Update is called once per frame
    void Update()
    {
        //transform.localScale = new Vector3(0,0,0) ; one way to set out scale to zeor. 
        transform.localScale = Vector3.one + Vector3.one * Mathf.Sin(Time.time * m_bounceFrequency) * m_bounceAmplitude; //time.time of how much time has passed in our application since it begans. Time.time is a float. 
    }


}
