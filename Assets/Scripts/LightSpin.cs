using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpin : MonoBehaviour
{

    [SerializeField] [Range(-50, 50f)] private float m_speed = 0.01f; 

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 0, rotation);
        transform.Rotate(Vector3.forward * m_speed * Time.deltaTime);
        
    }
}
