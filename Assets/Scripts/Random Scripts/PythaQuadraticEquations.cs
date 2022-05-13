using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
using UnityEngine.Events;


public class PythaQuadraticEquations : MonoBehaviour
{
    [SerializeField] private UnityEvent m_click;

    [Header(" Pythagoeram Calculation")]
    public float A;
    public float B;
    public float C;

    [Header(" Quadratic Equation")]
    public float a;
    public float b;
    public float c;

    private void Start()
    {
        pythagoram(A, B, C);

        quadraticequarion(A, B, C);
    }


    public void pythagoram(float A, float B, float C)
    {
        float aSquare = A * A;
        float bSqaure = B * B;
        float sumofAandB = aSquare + bSqaure;

        float sqroot = Mathf.Sqrt(sumofAandB);

        C = sqroot;
        Debug.Log(" Solution to Pythagoram Equation is: " + C);
        return;
    }

    public void quadraticequarion(float a, float b, float c)
    {
        // (-b + sqrt(b^2 - 4ac))/ (2a)
        // b^2 - 4ac if = 0 one real root
        // b^2 - 4ac if > 0 two real root
        // b^2 - 4ac if < 0 two complex real root

        float denominator = 2 * a;
        float discriminant = Mathf.Pow(b, 2) - 4 * a * c;

        float sqrtDiscriminant = Mathf.Sqrt(discriminant);

        float ver1 = -b + sqrtDiscriminant;
        float ver2 = -b - sqrtDiscriminant;

        float solution1 = ver1 / denominator;
        float solution2 = ver2 / denominator;

        if(discriminant == 0)
        {
            Debug.Log(" There is one real root");
            Debug.Log(" The solution for quadratic formula is : " + solution1 + " and " + solution2);

        }
        if (discriminant > 0)
        {
            Debug.Log(" There are two real roots");
            Debug.Log(" The solution for quadratic formula is : " + solution1 + " and " + solution2);


        }
        if (discriminant == 0)
        {
            Debug.Log(" There are two complex roots");
            Debug.Log(" The solution for quadratic formula is : " + solution1 + " and " + solution2);

        }





    }
        


}
