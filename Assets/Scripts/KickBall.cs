using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickBall : MonoBehaviour
{
    public GameObject ball;
    Rigidbody ballrb;

    public float kickRadius;
    public float dribblePower;
    public float shotPower;

    // Start is called before the first frame update
    void Start()
    {
        ballrb = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Shoot
        if (Input.GetKeyDown(KeyCode.RightShift) && Vector3.Distance(ball.transform.position, transform.position) < kickRadius) {
            Vector3 dir = ball.transform.position - transform.position;
            dir = dir.normalized;
            ballrb.AddForce(dir * shotPower, ForceMode.Impulse);
        }
        // Dribble
        else if (Input.GetKeyDown(KeyCode.Space) && Vector3.Distance(ball.transform.position, transform.position) < kickRadius) {
            Vector3 dir = ball.transform.position - transform.position;
            dir = dir.normalized;
            ballrb.AddForce(dir * dribblePower, ForceMode.Impulse);
        } 
    }
}
