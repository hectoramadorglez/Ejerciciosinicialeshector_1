using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVidas : MonoBehaviour
{
    // Start is called before the first frame update
    [Serializefield] int vidaInicial;
    int vidaActual;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Recibircura = RecibirCura(30);
        float vidaActualizada = RecibirDanho(12);
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
    float RecibirDanho(float danho)
    {
        vidaActual = vidaActual - 1;
        if (vidaActual == 0)
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
