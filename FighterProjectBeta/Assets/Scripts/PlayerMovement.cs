using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;
    float direction; // -1 or 1, representing left or right
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
        direction = Input.GetAxisRaw("Horizontal"); // calling input constantly, e.i. [-1, 1], from keyboard using Unity built in system.
        //Debug.Log(direction);

        force.x = direction;  // Only X in the Vector is changed to either 1 or -1.
        Debug.Log(force);
    }

    private void FixedUpdate() 
    {
        if (direction != 0)
        {
            body.velocity = force * speed;
        }
        else 
        {
            Vector2 hold;
            hold.x = 0;
            hold.y = body.velocity.y;
            body.velocity = hold;
        }
    }
}
