using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    
    void Start()
    {
        int divisor = numero2;
       
        if (divisor > 0 ) 
        {
            int resultado = numero1 / numero2;
            Debug.Log("El resultado de la division es "+resultado);        
        }
        else 
        {
            Debug.Log("El divisor no puede ser 0");
        
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
