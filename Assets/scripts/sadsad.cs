using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sadsad : MonoBehaviour
{
    public float altura;
    // Start is called before the first frame update
    void Start()
    {
        altura =transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 1, 0);
    }
}
