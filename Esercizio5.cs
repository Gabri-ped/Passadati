using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{ public int a = 14;
    // Start is called before the first frame update
    void Start()
    {
        if (a % 2 == 0)
        {
            Debug.Log("il numero � pari");
        }
        else
        {
            Debug.Log("il numero � dispari");
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
