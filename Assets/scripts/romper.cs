using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class romper : MonoBehaviour
{
    public GameObject rompo;
    private void Awake()
    {
        rompo.SetActive(false);
    }
    private void OnTriggerEnter(Collider deteccion)
    {
        Destroy(gameObject);
        rompo.SetActive(true);
    }
}
