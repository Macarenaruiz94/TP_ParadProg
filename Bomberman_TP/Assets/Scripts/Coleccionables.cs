using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionables : MonoBehaviour
{
    public bool active = false;

    /* void Activar()
    {
        if ( ) //si se ejecuta la función que destrulle los ladrillos se activan los items
        {
            active = true;
        }
    }*/
    private void OnCollisionEnter(Collision coll)
    {
        if (CompareTag("Player")) //destruir item cuando colisiona con el player
        {
            Destroy(this);
        }
    }
}
