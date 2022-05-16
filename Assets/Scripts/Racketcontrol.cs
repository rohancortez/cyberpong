using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Racketcontrol : MonoBehaviour
{

    public float speed;

    public KeyCode up;

    public KeyCode down;

    public bool isPlayer = true;

    public float offset = 0.2f;

    private Rigidbody rb;

    private Transform ball;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ball = GameObject.FindGameObjectWithTag("Ball").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.isPlayer)
        {
            MoveByPlayer();
        }
        else
        {
            MoveByComputer();
        }
    }

    private void MoveByPlayer()
    {
        bool pressedup = Input.GetKey(this.up);
        bool presseddown = Input.GetKey(this.down);
        
        if(pressedup)
        {
            rb.velocity = Vector3.forward * speed;
        }
        if(presseddown)
        {
            rb.velocity = Vector3.back * speed;
        }
        if(!pressedup && !presseddown)
        {
            rb.velocity = Vector3.zero;
        }
    }
    private void MoveByComputer()
    {
        if(ball.position.z > transform.position.z + offset)
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if(ball.position.z < transform.position.z - offset)
        {
            rb.velocity = Vector3.back * speed;
        }
        else{
            rb.velocity = Vector3.zero;
        }
    }
}
