using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    
    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += Time.deltaTime *  Vector3.forward * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Time.deltaTime * Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Time.deltaTime * Vector3.right * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Time.deltaTime * Vector3.back * speed;
        }
    }
}
