using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerShooting : MonoBehaviour
{
    public GameObject Bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetMouseButtonDown(0))
	    {
	        var bullet = Instantiate(Bullet,transform.position,transform.rotation);
            
	    }
	}
}
