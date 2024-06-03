
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightObject : MonoBehaviour
{ //NO APLICADO A OBJETOS EN ESCENA
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lightWall();
    }

    private void lightWall()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            gameObject.GetComponent<Light>().enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            gameObject.GetComponent<Light>().enabled = false;
        }
    }
}
