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
        if (Input.GetKey(InputReferenceManager.instance.movement.up))
        {
            transform.position += Vector3.up * speed;
            transform.eulerAngles = Vector3.zero;
        }
        if (Input.GetKey(InputReferenceManager.instance.movement.down))
        {
            transform.position += -Vector3.up * speed;
            transform.eulerAngles = new Vector3(0,0,180);
        }
        if (Input.GetKey(InputReferenceManager.instance.movement.left))
        {
            transform.position += -Vector3.right * speed;
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        if (Input.GetKey(InputReferenceManager.instance.movement.right))
        {
            transform.position += Vector3.right * speed;
            transform.eulerAngles = new Vector3(0, 0, 270);
        }

        if(Input.GetKey(InputReferenceManager.instance.movement.up) & Input.GetKey(InputReferenceManager.instance.movement.right))
        {
            transform.eulerAngles = new Vector3(0, 0, 315);

        }

        if (Input.GetKey(InputReferenceManager.instance.movement.down) & Input.GetKey(InputReferenceManager.instance.movement.right))
        {
            transform.eulerAngles = new Vector3(0, 0, 225);

        }

        if (Input.GetKey(InputReferenceManager.instance.movement.down) & Input.GetKey(InputReferenceManager.instance.movement.left))
        {
            transform.eulerAngles = new Vector3(0, 0, 135);

        }

        if (Input.GetKey(InputReferenceManager.instance.movement.up) & Input.GetKey(InputReferenceManager.instance.movement.left))
        {
            transform.eulerAngles = new Vector3(0, 0, 45);

        }

    }
}
