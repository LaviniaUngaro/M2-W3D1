using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i=1;i<=10;i++)
        {
            for (int j=1;j<=10;j++)
            {
                int tabellina = i * j;
                Debug.Log(i + " x " + j + " = " + tabellina);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
