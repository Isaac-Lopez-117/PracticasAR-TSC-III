using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    public GameManager gameManager;
    
    private void OnTriggerEnter(Collider collider)
    {
        // Verifica si el objeto ha llegado a la meta
        if (collider.gameObject.name == "Pelota")
        {
            Destroy(collider.gameObject);

            if (gameManager != null)
            {
                gameManager.indiceNivel += 1;
                gameManager.controlNiveles();
            }
        }
    }
}
