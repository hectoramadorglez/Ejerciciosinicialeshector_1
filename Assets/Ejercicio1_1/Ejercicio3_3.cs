using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    // Start is called before the first frame update
    public int numero = 5;

    void Start()
    {
        int doble = numero * 2;
        int triple = numero * 3;
        Debug.Log("El doble del numero es" + doble);
        Debug.Log("El triple del numero es" + triple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
