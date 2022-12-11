using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallReflector : MonoBehaviour
{
    public float reflectPower;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball") {
            Vector3 dir = other.transform.position - transform.position;
            dir = new Vector3(dir.x, 0f, 0f).normalized;
            other.GetComponent<Rigidbody>().AddForce(dir * reflectPower, ForceMode.Impulse);
        }
    }
}
