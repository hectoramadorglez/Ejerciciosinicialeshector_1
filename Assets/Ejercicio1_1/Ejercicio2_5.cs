using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ejercicio2_5 : MonoBehaviour
{
    // Start is called before the first frame update
    int vidasPlayer1 = 10;
    int vidasPlayer2 = 20;
    int vidasPlayer3 = 30;
    int vidasPlayer4 = 40;
    int variable;
    void Start()
    {
        Debug.Log("vidasPlayer1" +  vidasPlayer1);
        Debug.Log("vidasPlayer1" + vidasPlayer2);
        Debug.Log("vidasPlayer1" + vidasPlayer3);
        Debug.Log("vidasPlayer1" + vidasPlayer4);
        variable = vidasPlayer2;
        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = variable;
        Debug.Log("Vidas del player 1" + vidasPlayer1);
        Debug.Log("Vidas del player 2" + vidasPlayer2);
        Debug.Log("Vidas del player 3" + vidasPlayer3);
        Debug.Log("Vidas del player 4" + vidasPlayer4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
