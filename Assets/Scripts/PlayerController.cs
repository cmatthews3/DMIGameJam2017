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
            transform.position += transform.up * speed;
            transform.eulerAngles = Vector3.zero;
        }
        if (Input.GetKey(InputReferenceManager.instance.movement.down))
        {
            transform.position -= transform.up * speed;
            transform.eulerAngles = new Vector3(0,0,180);
        }
        else
        {
            body.velocity = Vector3.zero;
        }
    }
}
