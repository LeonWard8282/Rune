using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeTwoPTwo : MonoBehaviour
{
    [SerializeField] public int[] numbers_In_The_Array;
    int tempNumberHolder;
    bool bubblesorterDone = false;

    // Start is called before the first frame update
    void Start()
    {
        BubbleSorter();
    }

    // Update is called once per frame
    void Update()
    {
        



    }




    void BubbleSorter()
    {
       if( numbers_In_The_Array.Length >= 1)
        {
            Debug.Log("The Bubbler will now start bubbling its sorter.");

        }
        else
        {
            Debug.Log("There are no bubbles to sort with no values entered.");
        }
        
        // j equals to 0, but as long as j is less than the or equal to the length of the number in the array minus two, it will increment by one. 
        for( int j= 0; j <= numbers_In_The_Array.Length - 2; j++)
        {
            // i is equalt to 0 but as long as i is less than or equal to the lenth of the numebrs in the array minus two, it will increment by one. 
            for (int i = 0; i <= numbers_In_The_Array.Length - 2; i++)
            {
                // the index result in the numbers_in_Array. if said value is greater then the index result + 1 in the numbers_in_array. 
                // proceed and the following computation. 
                if(numbers_In_The_Array[i] > numbers_In_The_Array[i + 1])
                {
                    //variable "tempNumberHolder" equales to the the numbers_in_Array[i+1]. grabs the second value in the array. 
                    tempNumberHolder = numbers_In_The_Array[i + 1];
                    // the switcing occurs here. 
                    numbers_In_The_Array[i + 1] = numbers_In_The_Array[i];
                    // placing the 2nd value back. the swap of values is complete. 
                    numbers_In_The_Array[i] = tempNumberHolder;

                }


            }


        }
        bubblesorterDone = true;

        if( bubblesorterDone == true)
        {
            // for each index_number in numbers_in_Array
            foreach (int index_number in numbers_In_The_Array)
            {
                Debug.Log(index_number);
            }


            if (numbers_In_The_Array.Length >= 1)
            {
               Debug.Log(" The Values have been sorted. End of Script");
            }
            else
            {
                Debug.Log("End of Script");
            }


        }
    


    }



}
