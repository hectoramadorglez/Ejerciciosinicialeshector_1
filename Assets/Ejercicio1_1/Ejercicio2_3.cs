using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 7;
    float exp = 12.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        float producto = vidas * exp;
        float cociente = vidas / exp;
        float resto = vidas % (int)exp;
        int dobleVidas = vidas * 2;
        float tripleExp = exp * 3;
        Debug.Log(producto);
        Debug.Log(cociente);
        Debug.Log(resto);
        Debug.Log(dobleVidas);
        Debug.Log(tripleExp);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
