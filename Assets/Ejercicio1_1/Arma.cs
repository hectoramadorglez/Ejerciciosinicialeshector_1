using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    // Start is called before the first frame update
    bool automatica = false;
    [SerializeField] int danhomaximo;
    [SerializeField] int danhominimo;
    [SerializeField] int capacidadTotal;
    int municionActual = 40;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float utilizarArma() 
    {
        municion = municionActual - 1;
        if (municionActual == 0)
        {
            municionActual = 0;


        }
        else if (municionActual < 0)
        {
            Debug.Log("La cantidad introducida es negativa");
            municionActual = -1;


        }
        return municion;

    }
    float recargarArma() 
    { 
        if (municion < municionActual) 
        {
            municion++;
            
        } 
        return;
    
    }
}
