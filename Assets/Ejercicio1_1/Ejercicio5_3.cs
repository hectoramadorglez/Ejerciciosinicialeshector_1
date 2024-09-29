using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int numero1;
    
    void Start()
    {
        if (numero1 > 0 && numero1 < 9) 
        {
            Debug.Log("El numero se encuentra comprendido entre 0 y 9");
        
        
        }
        else 
        {
            Debug.Log("El numero no se encuentra entre estos dos numeros");
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
