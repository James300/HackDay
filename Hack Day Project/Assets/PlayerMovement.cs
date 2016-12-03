using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static float SpeedScalar = 10*Time.deltaTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    transform.Translate(transform.forward.x*SpeedScalar,transform.forward.y*SpeedScalar,transform.forward.z*SpeedScalar);
	}
}
