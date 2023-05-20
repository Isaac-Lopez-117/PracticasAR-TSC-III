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
            gameManager.indiceNivel += 1;
            if (gameManager.indiceNivel > 2)
            {
                gameManager.indiceNivel = 0;
            }
            Destroy(collider.gameObject);

            if (gameManager != null)
            {
                gameManager.controlNiveles();
            }
        }
    }
}
