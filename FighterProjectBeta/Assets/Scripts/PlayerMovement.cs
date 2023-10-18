using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;
    public float speed; // user inputs speed from Unity
    Vector2 force;      // (x , y)
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        force = body.velocity;
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal"); // calling input constantly, e.i. [-1, 1], from keyboard using Unity built in system.
        //Debug.Log(direction);

        force.x = direction;  // Only X in the Vector is changed to either 1 or -1.
        Debug.Log(force);
    }

    private void FixedUpdate() 
    {
        body.velocity = force * speed;
    }
}
