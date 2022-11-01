using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class escenarios : MonoBehaviour
{
    public GameObject[] mapas; 
    void Start()
    {
        nuevomapa();
    }
    public void nuevomapa()
    {
        Instantiate(mapas[Random.Range(0, mapas.Length)], transform.position, Quaternion.identity);

    }
}