using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float radio;
    float PI = 3.14f;
    


    void Start()
    {
        float circunferencia = 2 * PI * radio;
        float areaDeLaCircunferencia = PI * radio * radio;
        Debug.Log("El resulado de la circunferencia" +  circunferencia);
        Debug.Log("El resulado de la circunferencia" + areaDeLaCircunferencia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
