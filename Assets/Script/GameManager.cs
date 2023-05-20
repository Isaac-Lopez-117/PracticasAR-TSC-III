using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> muestraNiveles;
    public List<LevelManager> level;
    public int intentosTotal;
    public int indiceNivel;
    public int indices;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void controlIntentos()
    {
        intentosTotal += level[indiceNivel].intentos;
    }

    public void controlNiveles()
    {
        for (indices = 0; indices <= muestraNiveles.Count; indices++)
        {
            muestraNiveles[indices].SetActive(false);
        }
        muestraNiveles[indiceNivel].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        muestraNiveles[indiceNivel].SetActive(true);
    }
}
