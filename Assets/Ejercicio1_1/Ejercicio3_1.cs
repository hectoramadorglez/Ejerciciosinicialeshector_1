using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Console.Write("Escriba el primer numero entero");
        int numero1 = int.Parse(Console.ReadLine());
        Console.Write("Escriba el segundo numero entero");
        int numero2 = int.Parse(Console.ReadLine());
        Console.WriteLine("El primer numero" + numero1);
        Console.WriteLine("El primer numero" + numero2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
