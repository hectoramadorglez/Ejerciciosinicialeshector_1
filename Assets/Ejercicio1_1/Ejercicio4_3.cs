using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float resultadoaDolares = ConvertiraDolares(2.34f,"dolares");
        Debug.Log(resultadoaDolares);
        float resultadoaEuros = ConvertiraEuros(4.2f, "euros");
        Debug.Log (resultadoaEuros);
    }
    float ConvertiraDolares(float cantidad,string moneda) 
    {

        float resultado = cantidad * 1.11f;
        return resultado;
    
    }
    float ConvertiraEuros(float cantidad, string moneda)
    {

        float resultado = cantidad * 0.90f;
        return resultado;

    }
}
