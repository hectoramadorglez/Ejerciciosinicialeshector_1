using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string resultadofinal = ConstruirNombre("Pepe","Rodriguez","Jimenez",20);
        Debug.Log(resultadofinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string ConstruirNombre(string nombre, string apellido1, string apellido2, int edad) 
    {
        string resultado = "La personase llama " + nombre + " " + apellido1 + " " + apellido2 + "y tiene " + edad + "años";  
        return resultado;
    
    }
}
