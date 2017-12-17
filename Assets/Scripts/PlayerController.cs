using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveVert = 0;
        float moveHorizontal = 0;

        if (Input.GetKey(InputReferenceManager.instance.movement.up))
        {
            moveVert += 1;
            
        }
        if (Input.GetKey(InputReferenceManager.instance.movement.down))
        {
            moveVert -= 1;
        }
        if (Input.GetKey(InputReferenceManager.instance.movement.left))
        {
            moveHorizontal -= 1;
        }
        if (Input.GetKey(InputReferenceManager.instance.movement.right))
        {
            moveHorizontal += 1;
        }


        Vector3 heading = new Vector3(moveHorizontal, moveVert, 0).normalized;

        

        body.velocity = heading * speed;

        if (body.velocity.magnitude > 0.1f)
        {
            transform.up = body.velocity.normalized;
        }
    }
}
