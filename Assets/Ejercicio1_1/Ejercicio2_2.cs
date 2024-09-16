 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 4;
    float exp = 1.0f;
    char carac = 'a';
   
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vidas);
        Debug.Log(exp);
        float resultadoSuma = vidas + exp;
        float resultadoResta = exp - vidas;
        Debug.Log("Resultado de la suma" + resultadoSuma);
        Debug.Log("Resultado de la resta" + resultadoResta);
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
