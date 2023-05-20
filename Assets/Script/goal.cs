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
            // Cambiar el color del objeto
            //collider.gameObject.GetComponent<Renderer>().material.color = goalColor;
            gameManager.indiceNivel += 1;
            if (gameManager.indiceNivel > 3)
            {
                gameManager.indiceNivel = 0;
            }
            

        }
    }
}
