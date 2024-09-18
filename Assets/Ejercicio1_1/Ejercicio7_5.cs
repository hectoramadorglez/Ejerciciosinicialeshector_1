using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int contador;
    void Start()
    {
        while (contador > 0)
        {
            Debug.Log("Muestra los numeros" + contador);
            contador--;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
