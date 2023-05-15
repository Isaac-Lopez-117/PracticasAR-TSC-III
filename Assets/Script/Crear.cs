using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear : MonoBehaviour
{
    public GameObject objPrefab;
    public GameObject respawn;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Pelota") == null)
        {
            GameObject obj = Instantiate(objPrefab, respawn.transform);
            obj.name = "Pelota";
            obj.transform.localPosition = Vector3.zero;
            obj.transform.localRotation = Quaternion.identity;
        }
    }
}
