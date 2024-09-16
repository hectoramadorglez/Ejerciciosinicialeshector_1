using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultadofinaltriangulo = AreaTriangulo(4f, 2f);
        Debug.Log(resultadofinaltriangulo);
        float resultadofinalcirculo = AreaCirculo(3f, 3.14f);
        Debug.Log (resultadofinalcirculo);
        float resultadofinalCuadrado = AreaCuadrado(2f, 2f);
        Debug.Log(resultadofinalCuadrado);


    }

    // Update is called once per frame
    void Update()
    {

    }
    float AreaTriangulo(float basee, float altura) 
    {
        float resultado = (basee * altura) / 2;
        return resultado;



    }
    float AreaCirculo(float radio, float PI)
    {
        float resultado = (radio * radio) * PI;
        return resultado;



    }
    float AreaCuadrado(float lado, float lado2)
    {
        float resultado = lado * lado2;
        return resultado;



    }


}
