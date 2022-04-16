using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadrillosRompibles : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (CompareTag("Bomb"))
        {
            Destroy(this); //destruir los ladrillos cuando colisionen con la bomba y su rango de daño
        }
    }
}
