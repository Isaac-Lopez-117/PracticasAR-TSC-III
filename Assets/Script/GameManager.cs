using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> muestraNiveles;
    public List<LevelManager> level;

    public int intentosTotal;
    public int indiceNivel;
    public int indices;

    public TextMeshProUGUI intentosText; // Referencia al objeto de texto para mostrar el número de intentos
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

        controlIntentos();
        intentosText.text = "Intentos: " + intentosTotal.ToString(); // Actualiza el texto con el número de intentos total
    }
}
