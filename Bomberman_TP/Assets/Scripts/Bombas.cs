using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombas : MonoBehaviour
{
    float activar;
    public bool active = true;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Explotar()
    {
        if (KeyCode.E)
        {
            active = true;
        }
    }

    void DañoCausado()
    {

    }
}
