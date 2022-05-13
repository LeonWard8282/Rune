using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinLightManager : MonoBehaviour
{
    [SerializeField] private GameObject[] m_SpinLights;


    private void Start()
    {
        StartCoroutine(Flashlights());
    }




    IEnumerator Flashlights()// will give you an error if there is no error. This funtion needs a return.
    {
        
        while(true)
        {
            yield return new WaitForSeconds(0.5f); 
            
            
            foreach(GameObject go in m_SpinLights)
            {
                go.SetActive(!go.activeSelf); // toggle for the lights. 

            }

        }


    }

}
