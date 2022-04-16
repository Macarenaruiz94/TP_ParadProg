using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombas : MonoBehaviour
{
    float activar;
    public bool active = true;
   
    void Start()
    {
        active = false; //empezamos con la bomba desactivada
    }

    void Explotar()
    {
        if (KeyCode.E) //presionar la tecla "E" para activar la bomba
        {
            active = true;
            activar = 2; //esperar dos segundos antes de explotar
            Destroy(this);
        }
    }

    void DañoCausado()
    {
        if (active == true)
        {
            //destruir cuatro casillas al rededor de la bomba

        }
    }
}
