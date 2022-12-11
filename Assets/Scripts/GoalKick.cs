using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKick : MonoBehaviour
{
    public Transform spot;

    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Ball") {
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.transform.position = spot.position;
        }
    }
}
