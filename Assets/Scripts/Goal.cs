using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Transform spot;
    public int goals = 0;

    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Ball") {
            Debug.Log("GOOOOAAAAL!!!");
            goals++;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.transform.position = spot.position;
        }
    }
}
