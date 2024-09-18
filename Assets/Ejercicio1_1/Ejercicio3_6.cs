using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float velocidadKmH;
    void Start()
    {
        float velocidadMS = velocidadKmH *1000 / 3600;
        Debug.Log("Velocidad en m/s" +  velocidadMS);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
