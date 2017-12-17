using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearAIController : MonoBehaviour {

    public float wanderSpeed;
    public float wanderAmount;

    public float chasingSpeed;

    public Transform target;

    Vector3 targetVelocity;
    Vector3 targetFacing;

    Rigidbody2D body;
	
    // Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();

        StartCoroutine("WanderCoroutine");
	}

    IEnumerator WanderCoroutine()
    {
        while (true)
        {
            targetVelocity = transform.up * wanderSpeed + (Vector3)Random.insideUnitCircle * wanderAmount;
            targetFacing = targetVelocity.normalized;

            yield return new WaitForSeconds(1f);
        }
    }

    private void Update()
    {
        body.velocity = targetVelocity;

        if (body.velocity.magnitude > 0.1f)
        {
            transform.up = targetFacing;
        }
    }


}
