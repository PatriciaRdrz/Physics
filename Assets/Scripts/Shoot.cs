using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public float shootForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootObj();
    }
    private void ShootObj()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // GameObject ball = Instantiate(projectile);
            // projectile.trasnform.position = this.transform.localPosition;
            // ball.GetComponentt<Rigidbody>().AddForce(Vector3.forward * shootForce);

            GameObject ball = Instantiate(projectile, new Vector3(transform.position.x, transform.position.y, transform.position.z +1), Quaternion.identity);
            ball.GetComponent<Rigidbody>().AddForce(Vector3.right * shootForce);
        }
    }
}
