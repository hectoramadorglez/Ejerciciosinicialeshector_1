using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float baseTriangulo;
    [SerializeField] float alturaTriangulo;
    void Start()
    {
        float areaTriangulo = (baseTriangulo * alturaTriangulo)/2;
        Debug.Log("Area del triangulo" + areaTriangulo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
