using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    // Start is called before the first frame update
    int vidas = 10;
    
    void Start()
    {
        Debug.Log("Valor inicla de las vidas" +  vidas);
        vidas += 77;
        Debug.Log("Despues deincrementar 77"+ vidas);
        vidas -= 3;
        Debug.Log("Despues decrementar 3" + vidas);
        vidas *= 4;
        Debug.Log("Despues de cuadruplicar las vidas" + vidas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
