using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int intentos;

    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager.controlNiveles();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void numIntentos(){
        intentos += 1;
    }
}
