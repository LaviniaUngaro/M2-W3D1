using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    [SerializeField] int dimensione;
    [SerializeField] int minimo;
    [SerializeField] int massimo;

    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray(dimensione, minimo, massimo); // dichiarazione array

        StampaArray(array); // stampa array

        int min = TrovaMinimo(array);
        Debug.Log("Il numero più piccolo è " + min);

        int max = TrovaMassimo(array);
        Debug.Log("Il numero più grande è " + max);

        TrovaMinimi2(array);
        TrovaMassimi2(array);

    }

    int[] GeneraArray(int dimensione, int minimo, int massimo) // funzione per generare array
    {
        int[] array = new int[dimensione];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(minimo, massimo);
        }
        return array;
    }

    void StampaArray(int[] array) // funzione per stampa array
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }

    int TrovaMinimo(int[] array) // funzione per minimo
    {
        int minimo = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimo)
            {
                minimo = array[i];
            }
        }
        return minimo;
    }

    int TrovaMassimo(int[] array) // funzione per massimo
    {
        int massimo = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > massimo)
            {
                massimo = array[i];
            }
        }
        return massimo;
    }

    void TrovaMinimi2(int[] array)
    {
        int min1 = array[0];
        int min2 = array[1];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min1)
            {
                min2 = min1;
                min1 = array[i];
            }
            else if (array[i] < min2)
            {
                min2 = array[i];
            }
        }
        Debug.Log("I due numeri più piccoli sono: " + min1 + " e " + min2);
    }

    void TrovaMassimi2(int[] array)
    {
        int max1 = array[0];
        int max2 = array[1];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max1)
            {
                max2 = max1;
                max1 = array[i];
            }
            else if (array[i] > max2)
            {
                max2 = array[i];
            }
        }
        Debug.Log("I due numeri più grandi sono: " + max1 + " e " + max2);
    }
}