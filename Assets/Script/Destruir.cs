using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public GameManager gameManager;
    public List<LevelManager> levelManager;

    public void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.name == "Pelota")
        {  
            levelManager[gameManager.indiceNivel].numIntentos();
            Destroy(collider.gameObject);
            
            if (gameManager != null)
            {
                gameManager.indiceNivel -= 1;
                if (gameManager.indiceNivel < 0)
                {
                    gameManager.indiceNivel = 0;
                }
                gameManager.controlNiveles();
            }
        }
    }
}
