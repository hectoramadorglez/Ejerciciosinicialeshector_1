using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    // Start is called before the first frame update
    public float EXP;
    void Start()
    {
        float LVL = 32 + (9 * EXP / 5);
        Debug.Log("El nivel del personaje es: " + LVL);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
