using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    float velocidad = 6f;
    int puntaje = 0;

    private void Update()
    {
        Caminar();
    }

    void Caminar() //movimiento del player
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
    }

    void AgarrarItem() //si el player colisiona con los item, el puntaje sube de a uno
    {
        if (CompareTag("Item"))
        {
            puntaje =+ 1;
        }
    }

    void Destruirse()
    {
        if (CompareTag("Bomb"))
        {
            
            Destroy(this); //el player muere cuando colisiona con la bomba
        }
    }
}