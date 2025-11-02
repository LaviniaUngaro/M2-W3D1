using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    [SerializeField] int dimensione;
    [SerializeField] int minimo;
    [SerializeField] int massimo;

    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray(dimensione, minimo, massimo);

        StampaArray(array);

        int min = TrovaMinimo(array);
        Debug.Log("Il numero più piccolo è " + min);

        int max = TrovaMassimo(array);
        Debug.Log("Il numero più grande è " + max);

    }

    int[] GeneraArray(int dimensione, int minimo, int massimo) // funzione per dimensione
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
        for (int i=0; i<array.Length;i++)
        {
            if (array[i] > massimo)
            {
                massimo = array[i];
            }
        }
        return massimo;
    }
}