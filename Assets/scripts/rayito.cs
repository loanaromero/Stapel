using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rayito : MonoBehaviour
{
    public Transform lasercito;
    public Text puntaje;
    public GameObject cosito;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        RaycastHit hit;
        if(Physics.Raycast(transform.position,Vector3.right,out hit, 60f))
        {
            
            if (hit.transform.tag == "cubito"|| hit.transform.tag =="pisito")
            {
                Debug.DrawRay(transform.position, Vector3.right * 10f * Time.deltaTime, Color.red);
                Debug.Log("choke");
                altura();
                
                Debug.Log(puntaje);
               // Invoke("altura", 2);
            }
            else
            {
                baja();
            }
            
        }
        puntaje.text = lasercito.position.y.ToString("0");
    }
    public void altura()
    {
        gameObject.transform.Translate(0, 0.05f, 0);
        
    }
    public void baja()
    {
        gameObject.transform.Translate(0, -0.05f , 0);

    }
    
}
