using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    public List<GameObject> muestraNiveles;
    public List<LevelManager> level;
    public GameObject imageTargetParent;
    public GameObject pelota;

    public int intentosTotal;
    public int indiceNivel;
    public int indices;
    private int maxLevels = 2;
    private float tiempoRestante;

    public TextMeshProUGUI contadorText; // Referencia al objeto de texto para mostrar el tiempo restante
    public TextMeshProUGUI intentosText; // Referencia al objeto de texto para mostrar el número de intentos
    public Image pantallaPerdedor;
    public Image pantallaGanador;

    // Start is called before the first frame update
    void Start()
    {
        tiempoRestante = 30f; // 3 minutos en segundos
        pantallaPerdedor.gameObject.SetActive(false);
        pantallaGanador.gameObject.SetActive(false);
        imageTargetParent.gameObject.SetActive(true);
    }

    public void controlIntentos()
    {
        if(level[indiceNivel].intentos != 0)
        {
            intentosTotal += 1;
        }
        else
        {
            intentosTotal += level[indiceNivel].intentos;
        }
        
    }

    public void controlNiveles()
    {
        for (indices = 0; indices <= muestraNiveles.Count; indices++)
        {
            muestraNiveles[indices].SetActive(false);
        }
        muestraNiveles[indiceNivel].SetActive(true);
    }

    public void ReiniciarNivel()
    {
        Destroy(pelota.gameObject);
        intentosTotal = 0;
        for (int i = 0; i < maxLevels; i++)
        {
            level[i].intentos = 0;
        }
        tiempoRestante = 30f;
        pantallaPerdedor.gameObject.SetActive(false);
        pantallaGanador.gameObject.SetActive(false);
        imageTargetParent.gameObject.SetActive(true);
        indiceNivel = 0;
        controlNiveles();
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoRestante <= 0f)
        {
            pantallaPerdedor.gameObject.SetActive(true);
            imageTargetParent.gameObject.SetActive(false);
        }
        else if (indiceNivel > maxLevels)
        {
            pantallaGanador.gameObject.SetActive(true);
            imageTargetParent.gameObject.SetActive(false);
        }
        else
        {
            muestraNiveles[indiceNivel].SetActive(true);

            tiempoRestante -= Time.deltaTime;
            TimeSpan time = TimeSpan.FromSeconds(tiempoRestante);
            contadorText.text = "Tiempo restante: " + string.Format("{0:00}:{1:00}", time.Minutes, time.Seconds);
            
            intentosText.text = "Intentos: " + intentosTotal.ToString(); // Actualiza el texto con el número de intentos total
        }
    }
}
