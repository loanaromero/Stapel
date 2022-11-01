using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class logicapiezas : MonoBehaviour
{
    
    public float para = 0;
    public bool rotacion = true;
    public bool kieto;
    public float touchdeltaposicion;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = ("nuevapiezita");
     
        kieto = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        


        if (kieto == true)
        {
             gameObject.GetComponent<Rigidbody>().isKinematic = true;
            //gameObject.GetComponent<Rigidbody>().useGravity=true;
        }else
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }

        


        if (movimiento() == true)
        {
            
            if (Input.GetMouseButton(0))
            {
               
                    float pointer_x = Input.GetAxis("Mouse X");
                   // float pointer_z = Input.GetAxis("Mouse Y");
                    transform.Translate(-pointer_x * -0.2f, 0f,0f,Space.World);
                    //transform.Translate(0f, 0f, -pointer_z * -0.5f, Space.World);
                rotacion = false;
            }
            if (Input.GetMouseButtonUp(0))
            {
                
                kieto = false;
            }
            
        }
        if (rotacion == true)
        {
            transform.Rotate(new Vector3(0f, 0f, 120f) * Time.deltaTime);
            
        }
        
     
    }


    private bool collisonOccured = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collisonOccured)
            return;
         if (collision.gameObject.CompareTag("pisito") || collision.gameObject.CompareTag("nuevapiezita")|| collision.gameObject.CompareTag("alto")|| collision.gameObject.CompareTag("cubito"))
        {
            para = 1;
            gameObject.tag = "cubito";
            FindObjectOfType<ganerador>().nuevapieza();
            collisonOccured = true;   
        }





    }
























    /*void OnCollisionEnter(Collision collision)
    {
        GameObject cubo = GameObject.Find("cubo");
       
        
            para = 1;
            FindObjectOfType<ganerador>().nuevapieza();
        
       
    }*/

    bool movimiento()
    {
        if (para == 1)
        {
            return false;
        }

        return true;
    }

    
}
