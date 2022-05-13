using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Challenge2 : MonoBehaviour
{

    [SerializeField]    public int[] array_of_Numbers; // inputing a randome index size array of random integers. 
    public bool originalArraySorted = false; 
    bool toggle = false; // toggle boolean variable that "toggles" the call of the coroutine method that calls the arraysorter

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Calling Co-Routine From start, you will wait 3 seconds before array is sorted");
        StartCoroutine(Test()); 
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the toggle is true
        if(toggle == true)
        {
            toggle = false; // set the toggle to false
            StartCoroutine(Test()); // call a coroutine that will run the method Test()
        }
       
        
    }

    IEnumerator Test() // Method test will..
    {
        yield return new WaitForSeconds(3); //wait for 3 seconds on this line before moving on. 
        arraysorter(); // run the follwoing array asorting method
        toggle = true; // toggle bolean variable to true. 

    }


    void arraysorter()
    {

        Array.Sort(array_of_Numbers); // sort out and order small to bit the numbers in the array

        for(int i = 0; i < array_of_Numbers.Length; i++) // loop 1 where it will go through 0 to x numbers of iteration. 
        {
           
            if(originalArraySorted == false)// if the original array is sorted initialy it will run the following internal loop. 
            {
                for(int k = 0; k < array_of_Numbers.Length; k++)
                {
                    //Console.WriteLine(array_of_Numbers[i]);
                    Debug.Log("The sorted numbers in the Array are : " + array_of_Numbers[k]);
                }

                originalArraySorted = true; // when the internal loop is complete it locks with the orgirnall array sorted. 
                return; // closing out if statement
            }
            else
            {
                //Array.LastIndexOf(array_of_Numbers, UnityEngine.Random.Range(0, 100));                                    [0,1,2,3,4]
                array_of_Numbers[array_of_Numbers.Length - 1] = UnityEngine.Random.Range(0, 100);                         //[1,2,3,4,5]
                Debug.Log("The sorted numbers in the Array with Largest Number Replaced : " + array_of_Numbers[i]);

            }
        }

        
       

    }


}
