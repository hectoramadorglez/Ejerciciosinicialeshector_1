using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    // Start is called before the first frame update
    int puntuacion1 = 85;
    int puntuacion2 = 92;
    int puntuacion3 =72;
    void Start()
    {
        Debug.Log("Puntuacion 1" +  puntuacion1);
        Debug.Log("Puntuacion 2" + puntuacion2);
        Debug.Log("Puntuacion 3" + puntuacion3);
        double media = (puntuacion1 + puntuacion2 + puntuacion3) / 3.0;
        Debug.Log("La media de la puntuacion es" + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
