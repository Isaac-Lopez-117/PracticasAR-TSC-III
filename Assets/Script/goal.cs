using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    // Define una variable pública para el color de meta
    public Color goalColor = Color.green;

    private void OnTriggerEnter(Collider collider)
    {
        // Verifica si el objeto ha llegado a la meta
        if (collider.gameObject.name == "Pelota")
        {
            // Cambiar el color del objeto
            collider.gameObject.GetComponent<Renderer>().material.color = goalColor;
        }
    }
}
