using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int num1;
    [SerializeField] int num2;
    void Start()
    {
        Debug.Log("numero 1 es " + num1);
        Debug.Log("numero 2 es " + num2);
        while (num1 < num2)
        {
            Debug.Log("Muestra los numeros que estan entre" + num1);
            num1++;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
