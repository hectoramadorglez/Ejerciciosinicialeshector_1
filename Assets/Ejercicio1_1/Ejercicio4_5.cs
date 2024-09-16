using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultadofinalcirculo = AreaCirculo(3f, 3.14f);
       
        float resultadofinalconversion = ConvertiraDolares(resultadofinalcirculo,"dolares");
        Debug.Log(resultadofinalconversion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float AreaCirculo(float radio, float PI)
    {
        float resultadocirculo = (radio * radio) * PI;
        return resultadocirculo;



    }
    float ConvertiraDolares(float cantidad, string moneda)
    {

        float resultado = cantidad * 1.11f;
        return resultado;

    }
}
