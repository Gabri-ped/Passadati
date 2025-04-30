using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    public int number = 5;
    public int nbase = 6;
    public int multiple = 7;

    // Start is called before the first frame update
    void Start()
    {
        bool result;
        result = IsEven(number);
        if (result)
        {
            Debug.Log("il numero è" + number + "Pari");
        }
        else
        {
            Debug.Log("il numero è" + number + "Dispari");

            bool result2;
            result2 = IsMultipleOf(nbase, multiple);
            if (result2)
            {
                Debug.Log("Il numero è" + nbase + "Multiplo di" + multiple);
            }
            else
            {
                Debug.Log("il numero è" + nbase + "Non è multiplo di" + multiple);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    bool IsEven(int number)
    {
        if (number % 2 == 0)
            {
                return true;
            }
        return false;
    }
     bool  IsMultipleOf(int nbase, int multiple)

    {
        for (int i = 0; i < nbase; i++)
        {
            if (nbase * (i + 1) == multiple)
            {
                return true;
                
            }
           else return false;
        }
     }
}
