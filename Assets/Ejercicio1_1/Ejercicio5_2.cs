using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] int numero1;
    [SerializeField] int numero2;   
    void Start()
    {
        if(numero1< 3) 
        {
            Debug.Log("Es menor que 3");
        }
        if (numero2 < 3)
        {
            Debug.Log("Es menor que 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
