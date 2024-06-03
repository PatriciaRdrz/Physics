using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, Mathf.Infinity))
        { //if it does intersect:
            target = hit.collider.gameObject;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hit.distance, Color.red);
            Debug.Log("Did Hit");
            target.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * 1000, Color.blue);
            Debug.Log("Did not Hit");
            if (target != null)
            {
                target.GetComponent<MeshRenderer>().material.color = Color.gray;
            }
        }
    }
}