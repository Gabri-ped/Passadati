using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    public int a = 0;
    public int b = 42;
    public int c = 18;
    public int d = 4;
    // Start is called before the first frame update
    void Start()
    {
        int Addizione = a + b + c + d;
        Debug.Log(Addizione);
        int Prodotto = b * c * d;
        Debug.Log(Prodotto);
        long Media = (a+ b + c + d) / 4 ;
        Debug.Log(Media);
    }

    // Update is called once per frame 
    void Update()
    {
        
        
    }
} 
