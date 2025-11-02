using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    [SerializeField] int dimensione;
    [SerializeField] int minimo;
    [SerializeField] int massimo;
    [SerializeField] int dim;

    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray(dimensione, minimo, massimo);
        Debug.Log("vecchio array");
        StampaArray(array);

        int[] newArray = CambiaDimensioneArray(array, dim);
        if (newArray != array)
        {
            StampaArray(newArray);
        }
    }

    int[] GeneraArray(int dimensione, int minimo, int massimo)
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

    int[] CambiaDimensioneArray(int[] array, int dim)
    {
        if (dim == array.Length)
        {
            return array;
        }

        int[] newArray = new int[dim];
        for (int i = 0; i < dim; i++)
        {
            if (i < array.Length)
            {
                newArray[i] = array[i];
            }
            else
            {
                newArray[i] = 0;
            }
        }
        Debug.Log("nuovo array");
        return newArray;
    }

}
