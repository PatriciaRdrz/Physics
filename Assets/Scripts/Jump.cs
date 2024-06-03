using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce;
    Rigidbody rb;
    bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        JumpNeeded();
    }
    private void JumpNeeded()
    {
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            //this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
            rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
    private void OnCollisionExit(UnityEngine.Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            canJump = false;
        }
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            canJump = true;
        }
    }
}
