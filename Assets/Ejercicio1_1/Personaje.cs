using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    // Start is called before the first frame update
    private string nombre;
    private int vida;
    private int experiencia;
    private int LVL;
    bool miTurno = true;
    [SerializeField] int cura;
    private int vidaActual;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    float CalcularNivel()
    {

        LVL = experiencia / 1000;
        return LVL;


    }
    
    void enemigo() 
    { 
    
    
    }
    void sistemaDeVidas() 
    { 
    
    
    }
    void miArma()
    {
        
    }
}
