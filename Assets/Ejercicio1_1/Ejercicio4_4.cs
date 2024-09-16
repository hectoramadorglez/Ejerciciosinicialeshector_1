using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultadofinal = Velocidad(20);
        Debug.Log("Resultado en metros por segundo " + resultadofinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Velocidad(int velocidadenkm) 
    {
        float resultado = velocidadenkm / 3.6f;
        return resultado;
    
    }
}
