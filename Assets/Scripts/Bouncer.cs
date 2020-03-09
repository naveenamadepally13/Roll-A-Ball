using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    [SerializeField]
    float bouncePower = 100;
    void OnCollisionEnter(Collision collision)
    {
       Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        PlayerController pc = collision.gameObject.GetComponent<PlayerController>();

        Vector3 bounce = Vector3.Reflect(pc.lastVelocity, collision.contacts[0].normal);

        Debug.Log("Velocity" + pc.lastVelocity);
        Debug.Log("Bounce" + bounce * bouncePower);

        rb.AddForce(bounce.normalized * bouncePower);
    }
}
