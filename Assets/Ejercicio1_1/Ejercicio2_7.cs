using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    // Start is called before the first frame update
    int oroPorSegundo = 7;
    int horas = 4;
    int segundosPorhora = 3600;
    
    void Start()
    {
        int totalSegundos = horas * segundosPorhora;
        int oroTotal = oroPorSegundo * totalSegundos;
        Debug.Log("El total de oro farmeado es de" +  oroTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
