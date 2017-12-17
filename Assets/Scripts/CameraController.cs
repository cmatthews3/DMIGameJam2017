using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;

    public float height;

	
	
	// Update is called once per frame
	void Update () {
        transform.position = target.transform.position - new Vector3(0, 0, height);
	}
}
