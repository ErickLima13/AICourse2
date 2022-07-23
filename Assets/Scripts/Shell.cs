using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject explosion;

    //private float mass = 10;
    //private float force = 200;
    //private float accelerarion;
    //private float gravity = -9.8f;
    //private float gAccel;
    //private float speedZ;
    //private float speedY;

    private Rigidbody rigidbody;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tank")
        {
            GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //accelerarion = force / mass;
        //speedZ += accelerarion * Time.deltaTime;

        //gAccel = gravity / mass;
        //speedY += gAccel * Time.deltaTime;

        //transform.Translate(0, speedY, speedZ);

        //force = 0;

        transform.forward = rigidbody.velocity;
    }
}
