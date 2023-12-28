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

    public bool isDribbling = false;
    Vector3 ballOffset;

    // Start is called before the first frame update
    void Start()
    {
        ballrb = ball.GetComponent<Rigidbody>();
        ballOffset = new Vector3(0f, 1f, 1.8f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(ball.transform.position, transform.position) < kickRadius) {
            isDribbling = true;
            ball.transform.position = transform.position + transform.TransformVector(ballOffset);
        } else {
            isDribbling = false;
        }

        // Shoot
        if (Input.GetKeyDown(KeyCode.RightShift) && isDribbling) {
            Vector3 dir = ball.transform.position - transform.position;
            dir = dir.normalized;
            ballrb.AddForce(dir * shotPower, ForceMode.Impulse);
            isDribbling = false;
        }
        // Dribble
        else if (Input.GetKeyDown(KeyCode.Space) && isDribbling) {
            Vector3 dir = ball.transform.position - transform.position;
            dir = dir.normalized;
            ballrb.AddForce(dir * dribblePower, ForceMode.Impulse);
        } 
    }
}
