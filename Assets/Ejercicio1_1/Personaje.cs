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
    [SerializeField] int vidainicial;
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
    void SistemaDeVida()
    {
        int vida = vidainicial;

        
    
    
    }
    float RecibirCura(float cantidad) 
    { 
        int cura = vidaActual + 1;
        if (cura < 0) 
        {
            Debug.Log("La cura no puede tener un valor negativo");
        
        }
        return cura;
    
    
    }
    float RecibirDanho( float danho) 
    { 
        vidaActual = vidaActual - 1;
        if(vidaActual == 0) 
        { 
            vidaActual = 0;
        
        
        }  
        else if (vidaActual < 0) 
        {
            Debug.Log("La cantidad introducida es negativa");
            vidaActual = -1;
        
        
        }
        return vidaActual;
    
    
    }
}
