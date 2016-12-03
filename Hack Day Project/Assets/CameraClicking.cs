using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClicking : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        Vector3 fwd = transform.forward;

        if (Physics.Raycast(transform.position, fwd, 10))
            Debug.Log("SOMETHING IN FRONT");
    }
}
