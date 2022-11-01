using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logicaderrota : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private bool collisonOccured = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collisonOccured)
            return;
        if (collision.gameObject.CompareTag("cubito")||collision.gameObject.CompareTag("nuevapiezita"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
