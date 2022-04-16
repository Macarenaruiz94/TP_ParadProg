using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    int vida;
    float velocidad = 6f;

    private void Update()
    {
        Caminar();
    }

    void Caminar()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
    }

    void AgarrarItem()
    {
        if (CompareTag == Item)
        {
            
        }
    }

    void PonerBomba()
    {
        if (KeyCode.E)
        {
            
        }
    }

    void Destruirse()
    {

    }
}