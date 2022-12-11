using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody rb;
    public Transform kickoffSpot;

    public float dribbleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) Respawn();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player") {
            rb.AddForce(col.GetContact(0).normal * dribbleSpeed);
        }
    }

    void Respawn()
    {
        rb.velocity = Vector3.zero;
        transform.position = kickoffSpot.position;
    }
}
