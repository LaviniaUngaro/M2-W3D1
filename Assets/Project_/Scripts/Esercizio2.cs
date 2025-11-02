using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int c;

    // Start is called before the first frame update
    void Start()
    {
        bool even = isEven(a);
        if (even == true)
        {
            Debug.Log("Il numero " + a + " è pari");
        }
        else
        {
            Debug.Log("Il numero " + a + " è dispari");
        }

        bool multiple = isMultipleOf(b, c);
        if (multiple == true)
        {
            Debug.Log("Il numero " + c + " è multiplo del numero " + b);
        }
        else
        {
            Debug.Log("Il numero " + c + " NON è multiplo del numero " + b);
        }



        bool isEven(int a) // funzione
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool isMultipleOf(int b, int c) //funzione
        {
            if (c % b == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

// isEven --> input numero int - output true se è pari
// isMultipleOf --> input due numeri int - output true se il secondo è multiplo del primo
// 2 funzioni in start con argomento le 3 variabili
// stampa dei risultati